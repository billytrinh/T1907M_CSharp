namespace ConsoleApp1.Assignment4
{
    public class KhachHangNuocNgoai:KhachHang
    {
        private string country;

        public KhachHangNuocNgoai(int id, string name, string billDate, int number, string country) : base(id, name, billDate, number)
        {
            this.country = country;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public override int ThanhTien()
        {
            return Number*2000;
        }
    }
}