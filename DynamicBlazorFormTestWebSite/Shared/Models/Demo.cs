
namespace DynamicBlazorFormTestWebSite.Shared.Models
{
    public class Demo
    {


        public DemoBase demo1 { get; set; } = new DemoBase();
     

    }

    public class DemoBase
    {
        public DateTime test1 { get; set; } = DateTime.Now;

        public string test2 { get; set; } = Guid.NewGuid().ToString();

        public long test3 { get; set; } = DateTime.Now.Ticks;

        public bool test4 { get; set; } = true;
    }
}
