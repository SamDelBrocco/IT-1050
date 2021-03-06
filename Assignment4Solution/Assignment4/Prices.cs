﻿namespace Assignment4
{
    class Prices
    {
        public double TicketPrice =0;
        public int EveningTicketCount = 0;
        public double Discount1 = 0;
        public double Discount2 = 0;
        public double Discount3 = 0;

        const double priceSmallSoda = 3.50;
        const double priceLargeSoda = 5.99;
        const double priceHotDog = 3.99;
        const double pricePopcorn = 4.50;
        const double priceCandy = 1.99;

        public double totalConcessionPrice = 0;
        public int SmallSoda;
        public int LargeSoda;
        public int HotDog;
        public int Popcorn;
        public int Candy;

        public void GatherConcessionData()
        {
            SmallSoda = Question.AskForInt(" How many small sodas would you like?");
            LargeSoda = Question.AskForInt(" How many large sodas?");
            HotDog = Question.AskForInt(" How many Hot Dogs?");
            Popcorn = Question.AskForInt(" How many bags of popcorn?");
            Candy = Question.AskForInt(" How many pieces of Candy?");

            if (LargeSoda < Popcorn)
            {
                Discount1 = LargeSoda * 2;
            }
            else if (Popcorn < LargeSoda)
            {
                Discount1 = Popcorn * 2;
            }
            else
            {
                Discount1 = Popcorn * 2;
            }

            if (Candy >= 4)
            {
                Discount3 = (Candy / 4) * 1.99;
            }
        }


        public double GetConcessionPrice()
        {
            totalConcessionPrice += SmallSoda * priceSmallSoda;
            totalConcessionPrice += LargeSoda * priceLargeSoda;
            totalConcessionPrice += HotDog * priceHotDog;
            totalConcessionPrice += Popcorn * pricePopcorn;
            totalConcessionPrice += Candy * priceCandy;
            totalConcessionPrice -= Discount1;
            totalConcessionPrice -= Discount3;

            return totalConcessionPrice;
        }

        public void GatherMatineePrice()
        {
            int Child = Question.AskForInt(" How many childrens tickets do you need?");
            double ConversionChild = Child * 3.99;
            int Adult = Question.AskForInt(" How many Adult tickets do you need?");
            double ConversionAdult = Adult * 5.99;
            int Senior = Question.AskForInt(" How many Senior tickets do you need?");
            double ConversionofSenior = Senior * 4.50;

            TicketPrice = ConversionChild + ConversionAdult + ConversionofSenior;
        }

        public void GatherEveningPrice()
        {

            int Children = Question.AskForInt(" How many children tickets do you need?");
            double ConversionChild = Children * 6.99;
            int Adult = Question.AskForInt(" How many Adult tickets do you need?");
            double ConversionAdult = Adult * 10.99;
            int Senior = Question.AskForInt(" How many Senior tickets do you need?");
            double ConversionofSenior = Senior * 8.50;

            EveningTicketCount = Children + Adult + Senior;
            if (EveningTicketCount >= 3)
            {
                Discount2 = 4.50;
            }
            TicketPrice = ConversionChild + ConversionAdult + ConversionofSenior - Discount2;
        }
        
        public double GetTotalPurchase()
        {
            return this.TicketPrice + this.GetConcessionPrice();
        }

        
    }
}
