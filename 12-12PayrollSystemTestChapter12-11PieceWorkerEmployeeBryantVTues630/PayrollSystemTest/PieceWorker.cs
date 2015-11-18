using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




    class PieceWorker : Employee
    {

        //instance variables
        decimal pieces;
        decimal wage;


        //Constructor()
        public PieceWorker(string first, string last, string ssn, decimal wagePerPiece, decimal piecesProduced): base(first, last, ssn)
        {
            pieces = piecesProduced;
            wage = wagePerPiece;

        }//end Constructor(firstN, lastN, ssn, wage, peicesProduced)=count: 5 parameter constructor

        public decimal Wage
        {
            get
            {
                return wage;
            }//end get
            set
            {
                if(value>=0)
                {
                    wage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Wage", value, "Wage cannot be negative.");
                }//end if (Property: Wage)
            }//end set
        }////end Property: Wage

        public decimal Pieces
        {
            get
            {
                return pieces;
            }// end get
            set
            {
                if(value>=0)
                {
                    pieces = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Pieces", value, "Pieces Produced cannot be negative.");
                }//end if
            }//end set
        }//end Property Pieces

        public override decimal Earnings()
        {

            return Pieces * Wage;

        }//end MEthod Earnings

        public override string ToString()
        {
            return string.Format("Piece Worker Employee: {0}\n{1}: {2:C}; {3}: {4:F2}", base.ToString(),"Wage per piece produced: ", Wage.ToString(), "Pieces Produced", Pieces.ToString());

                 /*
                 * "hourly employee: {0}\n{1}: {2:C}; {3}: {4:F2}",
         base.ToString(), "hourly wage", Wage, "hours worked", Hours );
                 * */
        }
    }

