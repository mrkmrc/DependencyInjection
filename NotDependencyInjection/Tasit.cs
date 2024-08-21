using NotDependencyInjection.Tasitlar;

namespace NotDependencyInjection
{
    public class Tasit
    {
        Otomobil _otomobil;

        public Tasit()
        {
            _otomobil = new Otomobil();
        }

        public void Kullan()
        {
            _otomobil.GazVer();
            _otomobil.FrenYap();
        }
    }
}
