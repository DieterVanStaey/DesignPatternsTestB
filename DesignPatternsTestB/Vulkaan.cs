namespace DesignPatternsTestB
{
    public delegate void VulkaanUitbarsting();
    public class Vulkaan
    {
        private static Vulkaan deVulkaan;

        private Vulkaan()
        {

        }
        public static Vulkaan GetInstance()
        {
            if (deVulkaan == null)
            {
                deVulkaan = new Vulkaan();
            }

            return deVulkaan;
        }

        public event VulkaanUitbarsting VulkaanUitbarstingGebeurt;

        public void Uitbarsten()
        {
            if (VulkaanUitbarstingGebeurt != null)
                VulkaanUitbarstingGebeurt();
        }
    }
}
