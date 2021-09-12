using Foundation;
using System;
using System.Threading;
using UIKit;

namespace Nawache
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();            

            // adding cost value to specified text field after button click
            peopleInfoButton.TouchUpInside += (sender, e) =>
            {
                var alertController = UIAlertController.Create("Ile osób jechało ?", "Jako parametr należy wprowadzić liczbę osób znajdujących się w aucie w czasie przejazdu (tj. liczba osób przewożonych). Wartość domyślna to: 1 osoba.", UIAlertControllerStyle.Alert);
                alertController.AddAction(UIAlertAction.Create("Rozumiem", UIAlertActionStyle.Default, null));
                PresentViewController(alertController, true, null);
            };

            distanceInfoButton.TouchUpInside += (sender, e) =>
            {
                var alertController = UIAlertController.Create("Przebyty dystans.", "Jako parametr należy wprowadzić wartość liczbową (wyrażoną w km), określającą przebyty dystans w aucie.", UIAlertControllerStyle.Alert);
                alertController.AddAction(UIAlertAction.Create("Rozumiem", UIAlertActionStyle.Default, null));
                PresentViewController(alertController, true, null);
            };

            milageInfoButton.TouchUpInside += (sender, e) =>
            {
                var alertController = UIAlertController.Create("Spalanie na 100 km.", "Jako parametr należy wprowadzić wartość liczbową (wyrażoną w litrach na kilometr), określającą średnie zużycie paliwa na 100 km. Jest on zdefiniowany jako iloraz zatankowanego paliwa do przejechanych kilometrów pomnożony przez 100. Wiele pojazdów posiada wbudowany licznik spalania.", UIAlertControllerStyle.Alert);
                alertController.AddAction(UIAlertAction.Create("Rozumiem", UIAlertActionStyle.Default, null));
                PresentViewController(alertController, true, null);
            };

            fuelCostInfoButton.TouchUpInside += (sender, e) =>
            {
                var alertController = UIAlertController.Create("Cena paliwa za 1l.", "Jako parametr należy wprowadzić wartość liczbową (wyrażoną w litrach), określającą cenę za 1 litr tankowanego paliwa. Cenę można również dodać z listy poniżej klikając przycisk \"+\".", UIAlertControllerStyle.Alert);
                alertController.AddAction(UIAlertAction.Create("Rozumiem", UIAlertActionStyle.Default, null));
                PresentViewController(alertController, true, null);
            };

            weightInfoButton.TouchUpInside += (sender, e) =>
            {
                var alertController = UIAlertController.Create("Średnia waga osoby przewożonej.", "Jako parametr należy wprowadzić wartość liczbową (wyrażoną w kg), określającą średnią wagę przewożonej osoby w aucie. Dodatkowe obciążenie wpływa na podwyższenie wartości spalania auta, np.: 70kg = + 0,42l.", UIAlertControllerStyle.Alert);
                alertController.AddAction(UIAlertAction.Create("Rozumiem", UIAlertActionStyle.Default, null));
                PresentViewController(alertController, true, null);
            };
        }

        partial void generateResultButton(UIButton sender)
        {
            // setting "zł" for printing cost values
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pl-PL");

            // ------------------------------------------------ adding functionality for printing results          
            if (peopleInputTextField.Text == "0" || peopleInputTextField.Text.StartsWith("0") || string.IsNullOrEmpty(peopleInputTextField.Text))
            {
                var alert = UIAlertController.Create("Wystąpił błąd!", "Liczba osób nie może wynosić 0 lub zaczynać się od 0.", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);
                                
            }            
            else if (string.IsNullOrEmpty(distanceInputTextField.Text))
            {
                var alert = UIAlertController.Create("Wystąpił błąd!", "Przebyty dystans nie może być mniejszy od 1 km.", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);                
            }
            /*
             
            >>  << 

             */
            else // >> refactor <<
            {
                string d = distanceInputTextField.Text.Replace('.', ',');
                string m = milageInputTextField.Text.Replace('.', ',');
                
                double c = CalculateResults(d, m); // invoking method example
                printResultLabel1.Text = c.ToString("C2");
                costWithWeightLabel.Text = "kwota z obciążeniem";
                printResultLabel2.Text = c.ToString("C2");
                costWithoutWeightLabel.Text = "kwota bez obciążenia";
            }
        }

        private double CalculateResults(string _distance, string _milage) // example >> refactor it soon
        {
            var distance = double.Parse(_distance);
            var milage = double.Parse(_milage);
            var result = distance + milage;
            return result;
        }

        public override void DidReceiveMemoryWarning() => base.DidReceiveMemoryWarning();
        // Release any cached data, images, etc that aren't in use.

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }
    }
}