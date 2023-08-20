namespace Validationpplication.Models
{
    public static class Data
    {
        public static List<string> emails { get; set; }    

         static Data()
        {
            emails = new List<string>();
            emails.Add("div@test.com");
            emails.Add("div123@test.com");

        }

    }
}
