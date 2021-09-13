// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface ViewController : UIViewController {
	UILabel *_appNameHeader;
	UILabel *_costWithoutWeightLabel;
	UILabel *_costWithWeightLabel;
	UIButton *_distanceInfoButton;
	UITextField *_distanceInputTextField;
	UIButton *_fuelCostInfoButton;
	UITextField *_fuelCostInputTextField;
	UIButton *_milageInfoButton;
	UITextField *_milageInputTextField;
	UIButton *_peopleInfoButton;
	UITextField *_peopleInputTextField;
	UILabel *_printResultLabel1;
	UILabel *_printResultLabel2;
	UIButton *_weightInfoButton;
	UITextField *_weightPeopleInputTextField;
}


@property (nonatomic, retain) IBOutlet UILabel *appNameHeader;

@property (nonatomic, retain) IBOutlet UILabel *costWithoutWeightLabel;

@property (nonatomic, retain) IBOutlet UILabel *costWithWeightLabel;

@property (nonatomic, retain) IBOutlet UIButton *distanceInfoButton;

@property (nonatomic, retain) IBOutlet UITextField *distanceInputTextField;

@property (nonatomic, retain) IBOutlet UIButton *fuelCostInfoButton;

@property (nonatomic, retain) IBOutlet UITextField *fuelCostInputTextField;

@property (nonatomic, retain) IBOutlet UIButton *milageInfoButton;

@property (nonatomic, retain) IBOutlet UITextField *milageInputTextField;

@property (nonatomic, retain) IBOutlet UIButton *peopleInfoButton;

@property (nonatomic, retain) IBOutlet UITextField *peopleInputTextField;

@property (nonatomic, retain) IBOutlet UILabel *printResultLabel1;

@property (nonatomic, retain) IBOutlet UILabel *printResultLabel2;

@property (nonatomic, retain) IBOutlet UIButton *weightInfoButton;

@property (nonatomic, retain) IBOutlet UITextField *weightPeopleInputTextField;

- (IBAction)generateResultButton:(UIButton *)sender;

@end
