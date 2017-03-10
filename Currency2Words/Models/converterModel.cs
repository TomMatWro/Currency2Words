using Currency2Words.ServiceReference1;

namespace Currency2Words.Models
{
    public class ConverterModel
    {
        public string Input { get; set; }

        public string Result { get; set; }

        public void Convert2Words()
        {
            var client = new Service1Client();
            Result = client.GetData(5);
        }
    }
}