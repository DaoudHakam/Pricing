using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pricing
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


 

        private void btn_b_Click(object sender, EventArgs e)
        {
            double S, K, r, T, v;

            S = double.Parse(tb_S.Text);

            K = double.Parse(tb_K.Text);

            r = double.Parse(tb_r.Text);

            //q = double.Parse(tb_q.Text);

            T = double.Parse(tb_T.Text);

            v = double.Parse(tb_Sigma.Text);



            double d1 = (Math.Log(S / K) + (r + v * v / 2.0) * T) / v / Math.Sqrt(T);

            double d2 = d1 - v * Math.Sqrt(T);


            double b0 = 0.2316419;

            double b1 = 0.319381530;

            double b2 = -0.356563782;

            double b3 = 1.781477937;

            double b4 = -1.821255978;

            double b5 = 1.330274429;

            double pi = Math.PI;

            double phid1 = Math.Exp(-d1 * d1 / 2.0) / Math.Sqrt(2.0 * pi);

            double td1, cd1;

            double Nd1 = 0.5;

            if (d1 > 0.0)

            {

                td1 = 1.0 / (1.0 + b0 * d1);

                Nd1 = 1.0 - phid1 * (b1 * td1 + b2 * Math.Pow(td1, 2) + b3 * Math.Pow(td1, 3) + b4 * Math.Pow(td1, 4) + b5 * Math.Pow(td1, 5));

            }

            else if (d1 < 0.0)

            {

                d1 = -d1;

                td1 = 1.0 / (1.0 + b0 * d1);

                cd1 = 1.0 - phid1 * (b1 * td1 + b2 * Math.Pow(td1, 2) + b3 * Math.Pow(td1, 3) + b4 * Math.Pow(td1, 4) + b5 * Math.Pow(td1, 5));

                Nd1 = 1.0 - cd1;

            }

            double phid2 = Math.Exp(-d2 * d2 / 2.0) / Math.Sqrt(2.0 * pi);

            double td2, cd2;

            double Nd2 = 0.5;

            if (d2 > 0.0)

            {

                td2 = 1.0 / (1.0 + b0 * d2);

                Nd2 = 1.0 - phid2 * (b1 * td2 + b2 * Math.Pow(td2, 2) + b3 * Math.Pow(td2, 3) + b4 * Math.Pow(td2, 4) + b5 * Math.Pow(td2, 5));

            }

            else if (d2 < 0.0)

            {

                d2 = -d2;

                td2 = 1.0 / (1.0 + b0 * d2);

                cd2 = 1.0 - phid2 * (b1 * td2 + b2 * Math.Pow(td2, 2) + b3 * Math.Pow(td2, 3) + b4 * Math.Pow(td2, 4) + b5 * Math.Pow(td2, 5));

                Nd2 = 1.0 - cd2;

            }

            double Call = S * Nd1 - K * Math.Exp(-r * T) * Nd2;
            double Put = K * Math.Exp(-r * T) - S + Call;
            tb_black.Text = Call.ToString();
            tb_Put_black.Text = Put.ToString();

            double n(double x)
            {
                double A = 1.0 / Math.Sqrt(2.0 * 3.1415);
                return A * Math.Exp(-x * x * 0.5);
            }
            double N(double x)
            { // The approximation to the cumulative normal distribution
                double a1 = 0.4361836;
                double a2 = -0.1201676;
                double a3 = 0.9372980;
                double k = 1.0 / (1.0 + (0.33267 * x));
                if (x >= 0.0)
                {
                    return 1.0 - n(x) * (a1 * k + (a2 * k * k) + (a3 * k * k * k));
                }
                else
                {
                    return 1.0 - N(-x);
                }
            }
            //// Call
            double tmp = v * Math.Sqrt(T);
            //double d1 = (Math.Log(S / K) + (v * v) * 0.5 * T) / tmp;
            //double d2 = d1 - tmp;
            //double Call_price = (S  * N(d1)) - (K * Math.Exp(-r * T) * N(d2));

            //tb_black.Text = Call_price.ToString();
            //// Put
            //double Put_price =(K * Math.Exp(-r * T) *N(-d2)) - (S * T) * N(-d1);
            //tb_Put_black.Text =  Put_price.ToString();

            //// delta call
            double delta_call = Nd1;
            tb_deltaCall_black.Text = delta_call.ToString();
            // dlta put
            double delta_put = Nd1 - 1;
            tb_deltaPut_black.Text = delta_put.ToString();
            // gamma
            double gamma = n(d1) / (S * tmp);
            tb_gamma.Text = gamma.ToString();
            
            //// call theta
            double theta = -S * n(d1) * v / (2 * Math.Sqrt(T));
            theta += S * N(d1);
            theta -= r * K * Math.Exp(-r * T) * N(d2);
            tb_theta_call.Text = theta.ToString();
            // put theta
            double result = -S * n(d1) * v / (2 * Math.Sqrt(T));
            result -= S * N(-d1);
            result += r * K * Math.Exp(-r * T) * N(-d2);
            tb_theta_put.Text = result.ToString();
            //Vega 
            double vega = S * Math.Sqrt(T) * n(d1);
            tb_vega_call.Text = vega.ToString();
           
            //// rho call
            double rhocall = K * T * Math.Exp(-r * T) * N(d2);
            tb_rho_call.Text = rhocall.ToString();
            ////rho put
            double rhoput = -K * T * Math.Exp(-r * T) * N(-d2);
            tb_rho_put.Text = rhoput.ToString();

        }
        //  binomial


        public enum EPutCall
        {
            Call = 0,
            Put = 1
        }



        public class BinomialTree
        {


            private double assetPrice = 0.0;
            private double strike = 0.0;
            private double timeStep = 0.0;
            private double volatility = 0.0;
            private EPutCall putCall = EPutCall.Call;

            private double riskFreeRate = 0.0;
            private int steps = 0;




            public double AssetPrice
            {
                get { return assetPrice; }
                set { assetPrice = value; }
            }

            public double Strike
            {
                get { return strike; }
                set { strike = value; }
            }

            public double TimeStep
            {
                get { return timeStep; }
                set { timeStep = value; }
            }

            public double Volatility
            {
                get { return volatility; }
                set { volatility = value; }
            }

            public EPutCall PutCall
            {
                get { return putCall; }
                set { putCall = value; }
            }

            public double RiskFreeRate
            {
                get { return riskFreeRate; }
                set { riskFreeRate = value; }
            }

            public int Steps
            {
                get { return steps; }
                set { steps = value; }
            }










            /// <summary>
            /// Empty constructor.  All properties may be set.
            /// </summary>

            public BinomialTree()
            {
            }

            /// <summary>
            /// Constructor that takes all parameters used for calculatin option value using binomial tree
            /// </summary>
            /// <param name="assetPriceParam"></param>
            /// <param name="strikeParam"></param>
            /// <param name="timeStepParam"></param>
            /// <param name="volatilityParam"></param>
            /// <param name="riskFreeRateParam"></param>
            /// <param name="putCallParam"></param>
            /// <param name="optionStyleParam"></param>
            /// <param name="stepsParam"></param>
            public BinomialTree(
                double assetPriceParam,
                double strikeParam,
                double timeStepParam,
                double volatilityParam,
                double riskFreeRateParam,
                EPutCall putCallParam,
                int stepsParam)
            {
                assetPrice = assetPriceParam;
                strike = strikeParam;
                volatility = volatilityParam;
                timeStep = timeStepParam;
                riskFreeRate = riskFreeRateParam;
                putCall = putCallParam;
                steps = stepsParam;
            }






            #region "Binomial Tree"

            /// <summary>
            /// Part of the binomial node value equation, represents the binomial coefficient
            /// </summary>
            /// <param name="m"></param>
            /// <param name="n"></param>
            /// <returns></returns>



            private double BinomialCoefficient(int m, int n)
            {
                return Factorial(n) / (Factorial(m) * Factorial(n - m));
            }

            /// <summary>
            /// Calculates the value of an individual node in the binomial tree
            /// </summary>
            /// <param name="m"></param>
            /// <param name="n"></param>
            /// <param name="p"></param>
            /// <returns></returns>
            private double BinomialNodeValue(int m, int n, double p)
            {
                return BinomialCoefficient(m, n) * Math.Pow(p, (double)m) * Math.Pow(1.0 - p, (double)(n - m));
            }

            /// <summary>
            /// Returns the present value of the option
            /// </summary>
            /// <returns></returns>
            public double OptionValue()
            {
                double totalValue = 0.0;
                double u = OptionUp(timeStep, volatility, steps);
                double d = OptionDown(timeStep, volatility, steps);
                double p = Probability(timeStep, volatility, steps, riskFreeRate);
                double nodeValue = 0.0;
                double payoffValue = 0.0;
                for (int j = 0; j <= steps; j++)
                {
                    payoffValue = Payoff(AssetPrice * Math.Pow(u, (double)j) * Math.Pow(d, (double)(steps - j)), strike, putCall);
                    nodeValue = BinomialNodeValue(j, steps, p);
                    totalValue += nodeValue * payoffValue;
                }
                return PresentValue(totalValue, riskFreeRate, timeStep);
            }
            #endregion

            #region "Probabilities"


            private double OptionUp(double t, double s, int n)
            {
                return Math.Exp(s * Math.Sqrt(t / n));
            }

            private double OptionDown(double t, double s, int n)
            {
                return Math.Exp(-s * Math.Sqrt(t / n));
            }

            private double Probability(double t, double s, int n, double r)
            {
                double d1 = FutureValue(1.0, r, t / n);
                double d2 = OptionUp(t, s, n);
                double d3 = OptionDown(t, s, n);
                return (d1 - d3) / (d2 - d3);
            }
            #endregion

            #region "Payoffs"

            private double Payoff(double S, double X, EPutCall PutCall)
            {
                switch (PutCall)
                {
                    case EPutCall.Call:
                        return Call(S, X);

                    case EPutCall.Put:
                        return Put(S, X);

                    default:
                        return 0.0;
                }
            }

            private double Call(double S, double X)
            {
                return Math.Max(0.0, S - X);
            }

            private double Put(double S, double X)
            {
                return Math.Max(0.0, X - S);
            }
            #endregion

            #region "Financial Math Utility Functions"
            private double Factorial(int n)
            {
                double d = 1.0;
                for (int j = 1; j <= n; j++)
                {
                    d *= j;
                }
                return d;
            }

            private double FutureValue(double P, double r, double n)
            {
                return P * Math.Pow(1.0 + r, n);
            }

            private double PresentValue(double F, double r, double n)
            {
                return F / Math.Exp(r * n);
            }
            #endregion

        }

        private void btn_binomial_Click(object sender, EventArgs e)
        {


        

            BinomialTree tree = new BinomialTree(double.Parse(tb_S.Text), double.Parse(tb_K.Text), double.Parse(tb_T.Text), double.Parse(tb_Sigma.Text), double.Parse(tb_r.Text), EPutCall.Put, int.Parse(tb_steps.Text));

            double presentValue1 = tree.OptionValue();

            tb_put_binomial.Text = presentValue1.ToString();


            BinomialTree tree1 = new BinomialTree(double.Parse(tb_S.Text), double.Parse(tb_K.Text), double.Parse(tb_T.Text), double.Parse(tb_Sigma.Text), double.Parse(tb_r.Text), EPutCall.Call, int.Parse(tb_steps.Text));
            double presentValue2 = tree1.OptionValue();
            tb_call_Binomial.Text = presentValue2.ToString();



        }

        private void btn_M_Click_1(object sender, EventArgs e)
        {
            double Volatility = Convert.ToDouble(tb_Sigma.Text);
            double Maturity = Convert.ToDouble(tb_T.Text);
            double Spot = Convert.ToDouble(tb_S.Text);
            double IR = Convert.ToDouble(tb_r.Text);
            double NumberPaths = Convert.ToDouble(tb_paths.Text);
            double Strike = Convert.ToDouble(tb_K.Text);

            double Var = Volatility * Volatility * Maturity;
            double SpotTick = Spot * Math.Exp(IR * Maturity - 0.5* Var);
            double FinalSpot = 0;
            double Payoff = 0;
            double PayoffPut = 0;
            double ResultsPut = 0;
            double Results = 0;
            double price = 0;
            double pricePut = 0;
            double NormalVariable = 0;
            for (double i = 0; i < NumberPaths; i++)
            {
                NormalVariable = BoxMuller(); FinalSpot = SpotTick * Math.Exp(Math.Sqrt(Var) * NormalVariable);
                if ((FinalSpot - Strike) < 0)
                {
                    Payoff = 0;
                    PayoffPut = Strike - FinalSpot;
                    ResultsPut = PayoffPut + ResultsPut;
                }
                else
                {
                    Payoff = FinalSpot - Strike;
                    PayoffPut = 0;
                }
                Results = Payoff + Results;


            }
            price = Results / NumberPaths;
            price = price * Math.Exp(-IR * Maturity);
            tb_monte_call.Text = Convert.ToString(price);
            pricePut = ResultsPut / NumberPaths;
            pricePut = pricePut * Math.Exp(-IR * Maturity);
            tbn_monte_put.Text = Convert.ToString(pricePut);

            //Box - Muller function is simply written: 
            double BoxMuller()
            {
                double result_value = 0;
                double x1, x2, squared;
                do
                {
                    Random rand = new Random();
                    x1 = 2.0 * rand.NextDouble() - 1.0; x2 = 2.0 * rand.NextDouble() - 1.0; squared = x1 * x1 + x2 * x2;
                } while (squared >= 1.0);
                result_value = x1 * Math.Sqrt(-2 * Math.Log(squared) / squared);
                return result_value;
            }
        }


    }
    } 


