using System.Windows;

namespace Ayhan_Saglam_Exercise_01
{/*
    Exercise01 Build the following Dental Payment System App using WPF.
    You can use appropriate layout controls.If patient is Senior, then give 10% discount, 
    if he/she is in category –Kids/Youth then 15% discount. 
    Add one combo box under Address textbox 
    (drop down for Provinces –Alberta –HST 7%, Ontario-HST 13% and Quebec-HST  6%).
    As per the selection of the province, Total Charges should be calculated accordi*/

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        // Get Discount rate
        private double GetDiscountRate()
        {
            double discount = 0;
            if (RdBtnAdult.IsChecked != null && (bool)RdBtnAdult.IsChecked)
            {
                return discount;
            }
            else
            {
                if (RdBtnSenior.IsChecked != null && (bool)RdBtnSenior.IsChecked)
                {
                    discount = .10;
                    return discount;
                }
                else if (RdBtnKids.IsChecked != null && (bool)RdBtnKids.IsChecked)
                {
                    discount = .15;
                    return discount;
                }
            }

            return discount;
        }
        //Which province selected
        private string ValueProvinceGet()
        {

            return ProvinceInput.SelectionBoxItem.ToString();

        }
        //Which service selected?
        private int ValueChexBoxGet()
        {
            int a = 0, b = 0, c = 0;
            if (ChkBoxFlossing.IsChecked != null && (bool)ChkBoxFlossing.IsChecked)
            {
                a = 20;
            }
            if (ChkBoxFilling.IsChecked != null && (bool)ChkBoxFilling.IsChecked)
            {
                b = 75;

            }
            if (ChkBoxRootCanal.IsChecked != null && (bool)ChkBoxRootCanal.IsChecked)
            {
                c = 150;
            }



            return a + b + c;
        }
        private void ButtonCalculate_OnClick(object sender, RoutedEventArgs e)
        {
            //Arrange tax rate according selected province
            double tax = 0;
            string province = ValueProvinceGet();
            switch (province)
            {
                case "Alberta":
                case "Northwest Territories":
                case "Yukon":
                case "Nunavut":
                    tax = .05;
                    break;
                case "Saskatchewan":
                    tax = .11;
                    break;
                case "British Columbia":
                case "Manitoba":
                    tax = .12;
                    break;
                case "Ontario":
                    tax = .13;
                    break;
                case "Prince Edward Island":
                case "New Brunswick":
                case "Newfoundland and Labrador":
                case "Nova Scotia":
                    tax = .15;
                    break;
                case "Quebec":
                    tax = .1497;
                    break;



            }
           
            // Calculate Total Cost
            double beforeDiscount = ValueChexBoxGet() * (1 + tax);
            Patient patient = new Patient
            {
                PatientName = NameInput.Text, Value = beforeDiscount - (beforeDiscount * GetDiscountRate())
            };
            TextBlockResultView.Text = patient.ToString();
        }

        private void ButtonClear_OnClick(object sender, RoutedEventArgs e)
        {
            NameInput.Text = "";
            AddressInput.Text = "";
            ProvinceInput.Text = "";
            ChkBoxFlossing.IsChecked = false;
            ChkBoxFilling.IsChecked = false;
            ChkBoxRootCanal.IsChecked = false;
            RdBtnAdult.IsChecked = false;
            RdBtnKids.IsChecked = false;
            RdBtnSenior.IsChecked = false;
            TextBlockResultView.Text = "";




        }
    }
}
