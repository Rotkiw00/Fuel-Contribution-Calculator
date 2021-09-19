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

            try
            {
                peopleInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                peopleInputTextField.Layer.CornerRadius = 4;
                peopleInputTextField.Layer.BorderWidth = 1f;

                distanceInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                distanceInputTextField.Layer.CornerRadius = 4;
                distanceInputTextField.Layer.BorderWidth = 1f;

                milageInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                milageInputTextField.Layer.CornerRadius = 4;
                milageInputTextField.Layer.BorderWidth = 1f;

                fuelCostInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                fuelCostInputTextField.Layer.CornerRadius = 4;
                fuelCostInputTextField.Layer.BorderWidth = 1f;

                weightPeopleInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                weightPeopleInputTextField.Layer.CornerRadius = 4;
                weightPeopleInputTextField.Layer.BorderWidth = 1f;
            }
            catch (Exception)
            {
            }

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
            string people = peopleInputTextField.Text;
            string distance = distanceInputTextField.Text.Replace('.', ',');
            string milage100 = milageInputTextField.Text.Replace('.', ',');
            string fuelCost = fuelCostInputTextField.Text.Replace('.', ',');
            string avgW = weightPeopleInputTextField.Text.Replace('.', ',');

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pl-PL");

            if (string.IsNullOrEmpty(people) || string.IsNullOrEmpty(distance) || string.IsNullOrEmpty(milage100) || string.IsNullOrEmpty(fuelCost) || string.IsNullOrEmpty(avgW))
            {
                var alert = UIAlertController.Create("Wystąpił błąd!", "Dla poprawnego działania aplikacji zaleca się podanie wszystkich danych", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);

                if (string.IsNullOrEmpty(people))
                {
                    peopleInputTextField.Layer.BorderColor = UIColor.Red.CGColor;
                    peopleInputTextField.Layer.CornerRadius = 4;
                    peopleInputTextField.Layer.BorderWidth = 1f;
                }
                else
                {

                    peopleInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                    peopleInputTextField.Layer.CornerRadius = 4;
                    peopleInputTextField.Layer.BorderWidth = 1f;
                }

                if (string.IsNullOrEmpty(distance))
                {
                    distanceInputTextField.Layer.BorderColor = UIColor.Red.CGColor;
                    distanceInputTextField.Layer.CornerRadius = 4;
                    distanceInputTextField.Layer.BorderWidth = 1f;
                }
                else
                {

                    distanceInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                    distanceInputTextField.Layer.CornerRadius = 4;
                    distanceInputTextField.Layer.BorderWidth = 1f;
                }

                if (string.IsNullOrEmpty(milage100))
                {
                    milageInputTextField.Layer.BorderColor = UIColor.Red.CGColor;
                    milageInputTextField.Layer.CornerRadius = 4;
                    milageInputTextField.Layer.BorderWidth = 1f;
                }
                else
                {

                    milageInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                    milageInputTextField.Layer.CornerRadius = 4;
                    milageInputTextField.Layer.BorderWidth = 1f;
                }

                if (string.IsNullOrEmpty(fuelCost))
                {
                    fuelCostInputTextField.Layer.BorderColor = UIColor.Red.CGColor;
                    fuelCostInputTextField.Layer.CornerRadius = 4;
                    fuelCostInputTextField.Layer.BorderWidth = 1f;
                }
                else
                {

                    fuelCostInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                    fuelCostInputTextField.Layer.CornerRadius = 4;
                    fuelCostInputTextField.Layer.BorderWidth = 1f;
                }

                if (string.IsNullOrEmpty(avgW))
                {
                    weightPeopleInputTextField.Layer.BorderColor = UIColor.Red.CGColor;
                    weightPeopleInputTextField.Layer.CornerRadius = 4;
                    weightPeopleInputTextField.Layer.BorderWidth = 1f;
                }
                else
                {

                    weightPeopleInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                    weightPeopleInputTextField.Layer.CornerRadius = 4;
                    weightPeopleInputTextField.Layer.BorderWidth = 1f;
                }
            }
            else if (people == "0" || people.StartsWith("0"))
            {
                var alert = UIAlertController.Create("Wystąpił błąd!", "Musi być przynajmniej 1 osoba w aucie", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);
            }
            else if (double.Parse(distance) < 1.0)
            {
                var alert = UIAlertController.Create("Wystąpił błąd!", "Dystans musi wynosić conajmniej 1km", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);
            }
            else if (double.Parse(milage100) < 1.0)
            {
                var alert = UIAlertController.Create("Wystąpił błąd!", "Spalanie musi wynosić conajmniej 1l/100km", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);
            }
            else if (double.Parse(fuelCost) < 1.0)
            {
                var alert = UIAlertController.Create("Wystąpił błąd!", "Cena paliwa powinna być powyżej 0", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);
            }
            else if (double.Parse(avgW) < 1.0)
            {
                var alert = UIAlertController.Create("Wystąpił błąd!", "Średnia waga 1 osoby powinna być większa niż 1 kg", UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                PresentViewController(alert, true, null);
            }
            else 
            {
                peopleInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                peopleInputTextField.Layer.CornerRadius = 4;
                peopleInputTextField.Layer.BorderWidth = 1f;

                distanceInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                distanceInputTextField.Layer.CornerRadius = 4;
                distanceInputTextField.Layer.BorderWidth = 1f;

                milageInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                milageInputTextField.Layer.CornerRadius = 4;
                milageInputTextField.Layer.BorderWidth = 1f;

                fuelCostInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                fuelCostInputTextField.Layer.CornerRadius = 4;
                fuelCostInputTextField.Layer.BorderWidth = 1f;

                weightPeopleInputTextField.Layer.BorderColor = UIColor.White.CGColor;
                weightPeopleInputTextField.Layer.CornerRadius = 4;
                weightPeopleInputTextField.Layer.BorderWidth = 1f;

                double fullCost = CalculateWholeCost(people, distance, milage100, fuelCost, avgW);
                printResultLabel1.Text = fullCost.ToString("C2");
                costWithWeightLabel.Text = "całkowity koszt podróży";

                double sharedCost = ShareCostWith(fullCost, people);
                printResultLabel2.Text = sharedCost.ToString("C2");
                costWithoutWeightLabel.Text = "TWOJA ZRZUTKA";
            }
        }

        private double CalculateWholeCost(string _people, string _distance, string _milage, string _fuelCost, string _avgWeight)
        {
            int ppl = int.Parse(_people);
            double dist = double.Parse(_distance);
            double mil100 = double.Parse(_milage); 
            double fuelc = double.Parse(_fuelCost);
            double avgwght = double.Parse(_avgWeight);

            double additionalMilage = (avgwght * ppl * 0.6) / 100;
            double milageVal = (dist * mil100) / 100;
            double milageScaler = AdditionalMilageScaler(additionalMilage, dist);
            double csspzudc = milageVal + milageScaler;
            double wholeTripCost = csspzudc * fuelc;           

            return wholeTripCost;
        }

        private double AdditionalMilageScaler(double _additionalMillage, double _distance) => (_additionalMillage * _distance) / 100;

        private double ShareCostWith(double _whTripCost, string _people) => _whTripCost / int.Parse(_people);

        public override void DidReceiveMemoryWarning() => base.DidReceiveMemoryWarning();

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