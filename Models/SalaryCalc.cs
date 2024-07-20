namespace WelcomeProject.Models
{
    public class SalaryCalc
    {
        private double basic;
        private double ta;
        private double da;
        private double comm;
        private double pf;
        private double nol;

        public double Basic { get => basic; set => basic = value; }
        public double Ta { get => ta; set => ta = value; }
        public double Da { get => da; set => da = value; }
        public double Comm { get => comm; set => comm = value; }
        public double Pf { get => pf; set => pf = value; }
        public double Nol { get => nol; set => nol = value; }
    }
}
