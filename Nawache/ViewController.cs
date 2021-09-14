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
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pl-PL");

            if (string.IsNullOrEmpty(peopleInputTextField.Text) || string.IsNullOrEmpty(distanceInputTextField.Text) || string.IsNullOrEmpty(milageInputTextField.Text))
            {
                var alert = UIAlertController.Create("Wystąpił błąd!", "Dla poprawnego działania aplikacji zaleca się podanie wszystkich danych", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);
            }
            else if (peopleInputTextField.Text == "0" || peopleInputTextField.Text.StartsWith("0"))
            {
                var alert = UIAlertController.Create("Wystąpił błąd!", "Musi być przynajmniej 1 osoba w aucie", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);
            }
            //else if ()
            //{
            //    var alert = UIAlertController.Create("Wystąpił błąd!", "Dystans musi wynosić conajmniej 1 km", UIAlertControllerStyle.Alert);
            //    alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            //    PresentViewController(alert, true, null);
            //}
            /*
             
            >>  << 

             */
            else // >> refactor <<
            {
                string ppl = peopleInputTextField.Text;
                string d = distanceInputTextField.Text.Replace('.', ',');
                string m = milageInputTextField.Text.Replace('.', ',');
                string fc = fuelCostInputTextField.Text.Replace('.', ',');
                string avgw = weightPeopleInputTextField.Text.Replace('.', ',');

                double fullCost = CalculateWholeCost(ppl, d, m, fc, avgw); // invoking method example
                printResultLabel1.Text = fullCost.ToString("C2");
                costWithWeightLabel.Text = "całkowity koszt podróży";

                double sharedCost = ShareCostWith(fullCost, ppl);
                printResultLabel2.Text = sharedCost.ToString("C2");
                costWithoutWeightLabel.Text = "TWOJA ZRZUTKA";
            }
        }

        private double CalculateWholeCost(string _people, string _distance, string _milage, string _fuelCost, string _avgWeight) // example >> refactor it soon
        {
            int ppl = int.Parse(_people);
            double d = double.Parse(_distance);
            double m = double.Parse(_milage); // średnie spalanie paliwa
            double fc = double.Parse(_fuelCost);
            double avgw = double.Parse(_avgWeight);

            double additionalMilage = (avgw * ppl * 0.6) / 100;
            double csspzudc = m + additionalMilage;
            double wholeTripCost = csspzudc * fc;

            return wholeTripCost;
        }

        private double ShareCostWith(double whTripCost, string _people) => whTripCost / int.Parse(_people);

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