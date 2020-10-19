using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
namespace PointOfSale
{
    public class RegistrarFunction: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        MainWindow wnd = (MainWindow)Application.Current.MainWindow;

        double CurOwe;

        public double originalTotal;
        
        public RegistrarFunction(Order order)
        {
            originalTotal = order.Total;
        }

        private int penniesGiven = 0;
        /// <summary>
        /// sets and gets the money paid by the customer
        /// </summary>
        public int PenniesGiven
        {
            get => penniesGiven;
            set
            {
                penniesGiven = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesGiven"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
            }
        }

        private int nicklesGiven = 0;
        /// <summary>
        /// sets and gets the money paid by the customer
        /// </summary>
        public int NicklesGiven
        {
            get => nicklesGiven;
            set
            {
                nicklesGiven = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NicklesGiven"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
            }
        }

        private int dimesGiven = 0;
        /// <summary>
        /// sets and gets the money paid by the customer
        /// </summary>
        public int DimesGiven
        {
            get => dimesGiven;
            set
            {
                dimesGiven = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesGiven"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
            }
        }

        private int quartersGiven = 0;
        /// <summary>
        /// sets and gets the money paid by the customer
        /// </summary>
        public int QuartersGiven
        {
            get => quartersGiven;
            set
            {
                quartersGiven = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersGiven"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
            }
        }


        private int halfDollarsGiven = 0;
        /// <summary>
        /// sets and gets the money paid by the customer
        /// </summary>
        public int HalfDollarsGiven
        {
            get => halfDollarsGiven;
            set
            {
                halfDollarsGiven = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsGiven"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
            }
        }

        private int onesGiven = 0;
        /// <summary>
        /// sets and gets the money paid by the customer
        /// </summary>
        public int OnesGiven
        {
            get => onesGiven;
            set
            {
                onesGiven = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesGiven"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
            }
        }


        private int twosGiven = 0;
        /// <summary>
        /// sets and gets the money paid by the customer
        /// </summary>
        public int TwosGiven
        {
            get => twosGiven;
            set
            {
                twosGiven = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosGiven"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
            }
        }


        private int fivesGiven = 0;
        /// <summary>
        /// sets and gets the money paid by the customer
        /// </summary>
        public int FivesGiven
        {
            get => fivesGiven;
            set
            {
                fivesGiven = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesGiven"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
            }
        }


        private int tensGiven = 0;
        /// <summary>
        /// sets and gets the money paid by the customer
        /// </summary>
        public int TensGiven
        {
            get => tensGiven;
            set
            {
                tensGiven = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensGiven"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
            }
        }

        private int twentiesGiven = 0;
        /// <summary>
        /// sets and gets the money paid by the customer
        /// </summary>
        public int TwentiesGiven
        {
            get => twentiesGiven;
            set
            {
                twentiesGiven = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesGiven"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
            }
        }



        private int fiftiesGiven = 0;
        /// <summary>
        /// sets and gets the money paid by the customer
        /// </summary>
        public int FiftiesGiven
        {
            get => fiftiesGiven;
            set
            {
                fiftiesGiven = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesGiven"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
            }
        }

        private int hundredsGiven = 0;
        /// <summary>
        /// sets and gets the money paid by the customer
        /// </summary>
        public int HundredsGiven
        {
            get => hundredsGiven;
            set
            {
                hundredsGiven = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsGiven"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalPaid"));
            }
        }

        double totalPaid = 0;
        public double TotalPaid
        {
             
            get {
                 totalPaid = PenniesGiven * 0.01 + NicklesGiven * 0.05 + DimesGiven * 0.10 + QuartersGiven * 0.25 + HalfDollarsGiven * 0.50 + OnesGiven * 1.00 + TwosGiven * 2.00 + FivesGiven * 5.00 + TensGiven * 10.00 + TwentiesGiven * 20.00 + FiftiesGiven * 50.00 + HundredsGiven * 100;
                 return Math.Round(totalPaid, 2);
               
                }
           
        }

        private int penniesChange = 0;
        /// <summary>
        /// sets and gets the amount of money to give back to the customer
        /// </summary>
        public int PenniesChange
        {
            get => penniesChange;
            set
            {
                penniesChange = value;
                CurOwe -= penniesChange * 0.01;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurOwe"));
            }
        }


        private int nicklesChange = 0;
        /// <summary>
        /// sets and gets the amount of money to give back to the customer
        /// </summary>
        public int NicklesChange
        {
            get => nicklesChange;
            set
            {
                nicklesChange = value;
                CurOwe -= nicklesChange * 0.05;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NicklesChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurOwe"));
            }
        }

        private int dimesChange = 0;
        /// <summary>
        /// sets and gets the amount of money to give back to the customer
        /// </summary>
        public int DimesChange
        {
            get => dimesChange;
            set
            {
                dimesChange = value;
                CurOwe -= dimesChange * 0.10;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurOwe"));
            }
        }

        private int quartersChange = 0;
        /// <summary>
        /// sets and gets the amount of money to give back to the customer
        /// </summary>
        public int QuartersChange
        {
            get => quartersChange;
            set
            {
                quartersChange = value;
                CurOwe -= quartersChange * 0.25;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurOwe"));
            }
        }

        private int halfDollarsChange = 0;
        /// <summary>
        /// sets and gets the amount of money to give back to the customer
        /// </summary>
        public int HalfDollarsChange
        {
            get => halfDollarsChange;
            set
            {
                halfDollarsChange = value;
                CurOwe -= halfDollarsChange * 0.50;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarsChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurOwe"));
            }
        }


        private int oneChange = 0;
        /// <summary>
        /// sets and gets the amount of money to give back to the customer
        /// </summary>
        public int OnesChange
        {
            get => oneChange;
            set
            {
                oneChange = value;
                CurOwe -= oneChange * 1.00;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurOwe"));
            }
        }

        private int Twoschange = 0;
        /// <summary>
        /// sets and gets the amount of money to give back to the customer
        /// </summary>
        public int TwosChange
        {
            get => Twoschange;
            set
            {
                Twoschange = value;
                CurOwe -= Twoschange * 0.01;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurOwe"));
            }
        }

        private int Fiveschange = 0;
        /// <summary>
        /// sets and gets the amount of money to give back to the customer
        /// </summary>
        public int FivesChange
        {
            get => Fiveschange;
            set
            {
                Fiveschange = value;
                CurOwe -= Fiveschange * 5.00;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurOwe"));
            }
        }

        private int Tenschange = 0;
        /// <summary>
        /// sets and gets the amount of money to give back to the customer
        /// </summary>
        public int TensChange
        {
            get => Tenschange;
            set
            {
                Tenschange = value;
                CurOwe -= Tenschange * 10.00;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurOwe"));
            }
        }

        private int Twentieschange = 0;
        /// <summary>
        /// sets and gets the amount of money to give back to the customer
        /// </summary>
        public int TwentiesChange
        {
            get => Twentieschange;
            set
            {
                Twentieschange = value;
                CurOwe -= Twentieschange * 20.00;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurOwe"));
            }
        }

        private int Fiftieschange = 0;
        /// <summary>
        /// sets and gets the amount of money to give back to the customer
        /// </summary>
        public int FiftiesChange
        {
            get => Fiftieschange;
            set
            {
                Fiftieschange = value;
                CurOwe -= Fiftieschange * 50.00;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurOwe"));
            }
        }


        private int hundredsChange = 0;
        /// <summary>
        /// sets and gets the amount of money to give back to the customer
        /// </summary>
        public int HundredsChange
        {
            get => hundredsChange;
            set
            {
                hundredsChange = value;
                CurOwe -= hundredsChange * 20.00;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsChange"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurOwe"));
            }
        }

        public void ChangeDue(double ogAmount)
        {
            double remainder = ogAmount - TotalPaid;

            if(remainder >= 100)
            {
                if( HundredsGiven <=RoundRegister.CashDrawer.Hundreds)
                {
                    HundredsChange = (int)(remainder / 100);
                    remainder %= 100;
                }
            }

            if(remainder >= 50)
            {
                if( FiftiesGiven <= RoundRegister.CashDrawer.Fifties)
                {
                    FiftiesChange = (int)(remainder / 50);
                    remainder %= 50;
                }
            }

            if(remainder >= 20)
            {
                if( TwentiesGiven <= RoundRegister.CashDrawer.Twenties)
                {
                    TwentiesChange = (int)(remainder / 20);
                    remainder %= 20;
                }
            }

            if (remainder >= 10)
            {
                if (TensGiven <= RoundRegister.CashDrawer.Tens)
                {
                    TensChange = (int)(remainder / 10);
                    remainder %= 10;

                }
            }

            if(remainder >= 5)
            {
                if(FivesGiven <= RoundRegister.CashDrawer.Fives)
                {
                    FivesChange = (int)(remainder / 5);
                    remainder %= 5;
                }
            }

            if(remainder >= 1)
            {
                if(OnesGiven <= RoundRegister.CashDrawer.Ones)
                {
                    OnesChange = (int)(remainder / 1);
                    remainder %= 1;
                }
            }

            if(remainder >= 0.5)
            {
                if(HalfDollarsGiven <= RoundRegister.CashDrawer.HalfDollars)
                {
                    HalfDollarsChange = (int)(remainder / .5);
                    remainder %= .5;
                }
            }

            if(remainder >= 0.25)
            {
                if(QuartersGiven <= RoundRegister.CashDrawer.Quarters)
                {
                    QuartersChange = (int)(remainder / .25);
                    remainder %= .25;
                }
            }

            if(remainder >= 0.10)
            {
                if(DimesGiven <= RoundRegister.CashDrawer.Dimes)
                {
                    DimesChange = (int)(remainder / .1);
                    remainder %= .1;
                }
            }

            if(remainder >= 0.05)
            {
                if(NicklesGiven <= RoundRegister.CashDrawer.Nickels)
                {
                    NicklesChange = (int)(remainder / 0.05);
                    remainder %= 0.05;
                }
            }

            if (remainder >= 0.01)
            {
                if (PenniesGiven <= RoundRegister.CashDrawer.Pennies)
                {
                    PenniesChange = (int)(remainder / 0.01);
                    remainder %= 0.01;
                }
            }
        }


    }
}
