using Entities;

namespace Services
{
    public class ServiceResult<T>
    {
        private bool v1;
        private bool v2;
        private string empty;
        private object p;
        private string v;

        public ServiceResult(bool v1, bool v2, string empty)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.empty = empty;
        }

        public ServiceResult(bool v1, object p, string v)
        {
            this.v1 = v1;
            this.p = p;
            this.v = v;
        }

        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public SanPham Data { get; set; }
    }
}