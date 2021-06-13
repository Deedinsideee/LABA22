using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    abstract class Currency
    {
        protected double _rub;
        protected double _dlr;
        protected double _eur;

        public abstract void InRubles();
        public abstract void InDollars();
        public abstract void InEuros();

        public abstract void Print();
        
    }

    class Dollar: Currency
    {
        public Dollar(double cur)
        {
            _dlr = cur;
            _rub = 0;
            _eur = 0;
        }
        public override void InRubles()
        {
            _rub = _dlr * 74;
            
        }
        public override void InDollars()
        {
            
        }
        public override void InEuros()
        {
            _eur = _dlr * 0.84;
            
        }
        public override void Print()
        {
            if (_dlr < 0)
                Console.WriteLine("Перевод невозможен");

            if (_rub > 0 || (_rub == 0 && _dlr == 0))
            {
                Console.WriteLine($"{_dlr}DLR = {_rub}RUB");
            }

            if (_eur > 0 || (_eur == 0 && _dlr == 0))
            {
                Console.WriteLine($"{_dlr}DLR = {_eur}EUR");
            }
            Console.ReadLine();
        }

        public int Getx()
        {
            return 0;
        }
    }

    class Euro : Currency
    {
        public Euro(double cur)
        {
            _eur = cur;
            _dlr = 0;
            _rub = 0;
        }
        public override void InRubles()
        {
            _rub = _eur * 88;
            
        }
        public override void InDollars()
        {
            _dlr = _eur * 1.18;
            
        }
        public override void InEuros()
        {
            
        }
        public override void Print()
        {
            if (_eur < 0)
                Console.WriteLine("Перевод невозможен");

            if (_rub > 0 || (_rub == 0 && _eur == 0))
            {
                Console.WriteLine($"{_eur}EUR = {_rub}RUB");
            }

            if (_dlr > 0 || (_eur == 0 && _dlr == 0))
            {
                Console.WriteLine($"{_eur}EUR = {_dlr}DLR");
            }
            Console.ReadLine();
        }
    }
}
