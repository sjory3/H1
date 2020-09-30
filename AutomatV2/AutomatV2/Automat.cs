using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatV2
{
    class Automat
    {
        //---------------------------------------------------------------------------------------------------
        //making all the arrays for the diffrent variants and setting the max to 10
        Soda[] colaArray = new Soda[10];
        Alcohol[] tuborgArray = new Alcohol[10];
        Juice[] appleArray = new Juice[10];
        Snack[] havSaltArray = new Snack[10];
        Snack[] hariboArray = new Snack[10];
        //---------------------------------------------------------------------------------------------------
        //Restocking all the arrays with new objects
        public void restock()
        {
            //restocking or filling the array up with the obj
            for (int i = 0; i < colaArray.Length; i++)
            {
                //making a new obj
                Soda cola = new Soda("cola", 20, 500, 1, false);
                //putting the obj in the array
                colaArray[i] = cola;
            }

            //----------------------------------------------------------
            //the same as the above but for the diffrent obj and arrays
            //----------------------------------------------------------

            for (int i = 0; i < tuborgArray.Length; i++)
            {
                Alcohol tuborg = new Alcohol("Tuborg", 25, 333, 1, 4.5f);
                tuborgArray[i] = tuborg;
            }
            for (int i = 0; i < appleArray.Length; i++)
            {
                Juice appleJuice = new Juice("Apple Juice", 15, 125, 0, "Apple");
                appleArray[i] = appleJuice;
            }
            for (int i = 0; i < havSaltArray.Length; i++)
            {
                Snack havSalt = new Snack("Kims Havsalt", 20, 150, "Chips");
                havSaltArray[i] = havSalt;
            }
            for (int i = 0; i < hariboArray.Length; i++)
            {
                Snack haribo = new Snack("Haribo", 25, 250, "gummies");
                hariboArray[i] = haribo;
            }
        }

        //a method for each array to count how many objects exist within
        public int ColaCount()
        {
            //the to be ruturned value
            int colaCount = 0;
            //running though the hole array
            foreach (Soda cola in colaArray)
            {
                //making sure that the counter does not count null in the array
                if (cola != null)
                {
                    colaCount++;
                }
            }
            //returning the int
            return colaCount;
        }
        //-------------------------------------------------
        //  The same as above but for the diffrent objects
        //-------------------------------------------------
        public int TuborgCount()
        {

            int tuborgCount = 0;

            foreach (Alcohol tuborg in tuborgArray)
            {
                if (tuborg != null)
                {
                    tuborgCount++;
                }
            }

            return tuborgCount;
        }
        public int AppleCount()
        {
            int appleCount = 0;

            foreach (Juice appleJuice in appleArray)
            {
                if (appleJuice != null)
                {
                    appleCount++;
                }
            }
            return appleCount;
        }
        public int HavSaltCount()
        {
            int havSaltCount = 0;

            foreach (Snack havSalt in havSaltArray)
            {
                if (havSalt != null)
                {
                    havSaltCount++;
                }
            }
            return havSaltCount;
        }
        public int HariboCount()
        {
            int hariboCount = 0;

            foreach (Snack haribo in hariboArray)
            {
                if (haribo != null)
                {
                    hariboCount++;
                }
            }
            return hariboCount;
        }

        //displaying Haribo info, but making a metod for each so i can reffrence only the price when i need the price
        public string HariboName()
        {
            //making a emty object to store information
            Snack hariboInfo = new Snack();
            //the for loop is to update the name from the obj allready in the array and making sure that it does not take a null object
            for (int i = 0; i < hariboArray.Length; i++)
            {
                if (havSaltArray[i] != null)
                {
                    hariboInfo = hariboArray[i];
                    i = hariboArray.Length + 1;
                }
            }
            //making a return value and returning it
            string havSaltNameReturn = hariboInfo.Name;

            return havSaltNameReturn;
        }
        //---------------------------------------------------
        // the same as above but for price, gram etc.
        //---------------------------------------------------
        public int HariboPrice()
        {
            Snack hariboInfo = new Snack();

            for (int i = 0; i < hariboArray.Length; i++)
            {
                if (hariboArray[i] != null)
                {
                    hariboInfo = hariboArray[i];
                    i = hariboArray.Length + 1;
                }
            }
            int havSaltPriceReturn = hariboInfo.Price;

            return havSaltPriceReturn;
        }
        public int HariboGram()
        {
            Snack hariboInfo = new Snack();
            for (int i = 0; i < hariboArray.Length; i++)
            {
                if (hariboArray[i] != null)
                {
                    hariboInfo = hariboArray[i];
                    i = hariboArray.Length + 1;
                }
            }
            int hariboGramReturn = hariboInfo.G;

            return hariboGramReturn;
        }
        public string HariboType()
        {
            Snack hariboInfo = new Snack();
            for (int i = 0; i < hariboArray.Length; i++)
            {
                if (hariboArray[i] != null)
                {
                    hariboInfo = hariboArray[i];
                    i = hariboArray.Length + 1;
                }
            }
            string hariboTypeReturn = hariboInfo.Type;

            return hariboTypeReturn;
        }

        //--------------------------------------------------------------------------------------------------------------
        //           THE SAME AS ABOVE BUT FOR DIFFRENT OBJECTS
        //--------------------------------------------------------------------------------------------------------------

        //displaying HavSalt info, but making a metod for each so i can reffrence only the price when i need the price
        public string HavSaltName()
        {
            Snack havSaltInfo = new Snack();

            for (int i = 0; i < havSaltArray.Length; i++)
            {
                if (havSaltArray[i] != null)
                {
                    havSaltInfo = havSaltArray[i];
                    i = havSaltArray.Length + 1;
                }
            }

            string havSaltNameReturn = havSaltInfo.Name;

            return havSaltNameReturn;
        }
        public int HavSaltPrice()
        {
            Snack havSaltInfo = new Snack();

            for (int i = 0; i < havSaltArray.Length; i++)
            {
                if (havSaltArray[i] != null)
                {
                    havSaltInfo = havSaltArray[i];
                    i = havSaltArray.Length + 1;
                }
            }
            int havSaltPriceReturn = havSaltInfo.Price;

            return havSaltPriceReturn;
        }
        public int HavSaltGram()
        {
            Snack havSaltInfo = new Snack();
            for (int i = 0; i < havSaltArray.Length; i++)
            {
                if (havSaltArray[i] != null)
                {
                    havSaltInfo = havSaltArray[i];
                    i = havSaltArray.Length + 1;
                }
            }
            int havSaltGramReturn = havSaltInfo.G;

            return havSaltGramReturn;
        }
        public string HavSaltType()
        {
            Snack havSaltInfo = new Snack();
            for (int i = 0; i < havSaltArray.Length; i++)
            {
                if (havSaltArray[i] != null)
                {
                    havSaltInfo = havSaltArray[i];
                    i = havSaltArray.Length + 1;
                }
            }
            string havSaltTypeReturn = havSaltInfo.Type;

            return havSaltTypeReturn;
        }

        //cola
        public string ColaName()
        {
            Drink colaInfo = new Drink();

            for (int i = 0; i < colaArray.Length; i++)
            {
                if (colaArray[i] != null)
                {
                    colaInfo = colaArray[i];
                    i = colaArray.Length + 1;
                }
            }
            string colaNameReturn = colaInfo.Name;
            return colaNameReturn;
        }
        public int ColaPrice()
        {
            Drink colaInfo = new Drink();

            for (int i = 0; i < colaArray.Length; i++)
            {
                if (colaArray[i] != null)
                {
                    colaInfo = colaArray[i];
                    i = colaArray.Length + 1;
                }
            }
            int colaPriceReturn = colaInfo.Price;

            return colaPriceReturn;
        }
        public int ColaMl()
        {
            Drink colaInfo = new Drink();

            for (int i = 0; i < colaArray.Length; i++)
            {
                if (colaArray[i] != null)
                {
                    colaInfo = colaArray[i];
                    i = colaArray.Length + 1;
                }
            }
            int colaMlReturn = colaInfo.Ml;
            return colaMlReturn;
        }
        public int ColaPant()
        {
            Drink colaInfo = new Drink();
            for (int i = 0; i < colaArray.Length; i++)
            {
                if (colaArray[i] != null)
                {
                    colaInfo = colaArray[i];
                    i = colaArray.Length + 1;
                }
            }
            int colaPantReturn = colaInfo.Pant;
            return colaPantReturn;
        }
        public bool ColaSugerFree()
        {
            Soda colaInfo = new Soda();
            for (int i = 0; i < colaArray.Length; i++)
            {
                if (colaArray[i] != null)
                {
                    colaInfo = colaArray[i];
                    i = colaArray.Length + 1;
                }
            }
            bool colaSugerFreeReturn = colaInfo.Sugerfree;
            return colaSugerFreeReturn;
        }

        //tuborg
        public string TuborgName()
        {
            Drink tuborgInfo = new Drink();

            for (int i = 0; i < tuborgArray.Length; i++)
            {
                if (tuborgArray[i] != null)
                {
                    tuborgInfo = tuborgArray[i];
                    i = tuborgArray.Length + 1;
                }
            }
            string tuborgNameReturn = tuborgInfo.Name;
            return tuborgNameReturn;
        }
        public int TuborgPrice()
        {
            Drink tuborgInfo = new Drink();

            for (int i = 0; i < tuborgArray.Length; i++)
            {
                if (tuborgArray[i] != null)
                {
                    tuborgInfo = tuborgArray[i];
                    i = tuborgArray.Length + 1;
                }
            }
            int tuborgPriceReturn = tuborgInfo.Price;

            return tuborgPriceReturn;
        }
        public int TuborgMl()
        {
            Drink tuborgInfo = new Drink();

            for (int i = 0; i < tuborgArray.Length; i++)
            {
                if (tuborgArray[i] != null)
                {
                    tuborgInfo = tuborgArray[i];
                    i = tuborgArray.Length + 1;
                }
            }
            int tuborgMlReturn = tuborgInfo.Ml;
            return tuborgMlReturn;
        }
        public int TuborgPant()
        {
            Drink tuborgInfo = new Drink();
            for (int i = 0; i < tuborgArray.Length; i++)
            {
                if (tuborgArray[i] != null)
                {
                    tuborgInfo = tuborgArray[i];
                    i = tuborgArray.Length + 1;
                }
            }
            int tuborgPantReturn = tuborgInfo.Pant;
            return tuborgPantReturn;
        }
        public float TuborgVol()
        {
            Alcohol tuborgInfo = new Alcohol();
            for (int i = 0; i < tuborgArray.Length; i++)
            {
                if (tuborgArray[i] != null)
                {
                    tuborgInfo = tuborgArray[i];
                    i = tuborgArray.Length + 1;
                }
            }
            float tuborgVolReturn = tuborgInfo.Vol;
            return tuborgVolReturn;
        }

        //appleJuice
        public string AppleName()
        {
            Drink appleInfo = new Drink();

            for (int i = 0; i < appleArray.Length; i++)
            {
                if (appleArray[i] != null)
                {
                    appleInfo = appleArray[i];
                    i = appleArray.Length + 1;
                }
            }
            string appleNameReturn = appleInfo.Name;
            return appleNameReturn;
        }
        public int ApplePrice()
        {
            Drink appleInfo = new Drink();

            for (int i = 0; i < appleArray.Length; i++)
            {
                if (appleArray[i] != null)
                {
                    appleInfo = appleArray[i];
                    i = appleArray.Length + 1;
                }
            }
            int applePriceReturn = appleInfo.Price;

            return applePriceReturn;
        }
        public int AppleMl()
        {
            Drink appleInfo = new Drink();

            for (int i = 0; i < appleArray.Length; i++)
            {
                if (appleArray[i] != null)
                {
                    appleInfo = appleArray[i];
                    i = appleArray.Length + 1;
                }
            }
            int appleMlReturn = appleInfo.Ml;
            return appleMlReturn;
        }
        public int ApplePant()
        {
            Drink appleInfo = new Drink();
            for (int i = 0; i < appleArray.Length; i++)
            {
                if (appleArray[i] != null)
                {
                    appleInfo = appleArray[i];
                    i = appleArray.Length + 1;
                }
            }
            int applePantReturn = appleInfo.Pant;
            return applePantReturn;
        }
        public string AppleType()
        {
            Juice appleInfo = new Juice();
            for (int i = 0; i < appleArray.Length; i++)
            {
                if (appleArray[i] != null)
                {
                    appleInfo = appleArray[i];
                    i = appleArray.Length + 1;
                }
            }
            string appleTypeReturn = appleInfo.Type;
            return appleTypeReturn;
        }

        //--------------------------------------------------------------------------------
        //       DELETING OBJECTS FROM THE ARRAYS
        //--------------------------------------------------------------------------------

        //mathod for checking the what space in the array there is an objcet and deleting it
        public void DeleteHavSalt()
        {
            //making sure it takes an object that exits and not changing a null value to null
            for (int i = 0; i < havSaltArray.Length; i++)
            {
                if (havSaltArray[i] != null)
                {
                    havSaltArray[i] = null;
                    i = havSaltArray.Length + 1;
                }
            }
        }
        //----------------------------------------------
        // The same as above but for diffrent objects
        //---------------------------------------------
        public void DeleteHaribo()
        {
            for (int i = 0; i < hariboArray.Length; i++)
            {

                if (hariboArray[i] != null)
                {

                    hariboArray[i] = null;
                    i = hariboArray.Length + 1;
                }
            }
        }
        public void DeleteCola()
        {
            for (int i = 0; i < colaArray.Length; i++)
            {

                if (colaArray[i] != null)
                {

                    colaArray[i] = null;
                    i = colaArray.Length + 1;
                }
            }
        }
        public void DeleteTuborg()
        {
            for (int i = 0; i < tuborgArray.Length; i++)
            {

                if (tuborgArray[i] != null)
                {

                    tuborgArray[i] = null;
                    i = tuborgArray.Length + 1;
                }
            }
        }
        public void DeleteApple()
        {
            for (int i = 0; i < appleArray.Length; i++)
            {

                if (appleArray[i] != null)
                {

                    appleArray[i] = null;
                    i = appleArray.Length + 1;
                }
            }
        }
    }
}