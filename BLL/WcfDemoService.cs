using IBLL;

namespace BLL
{
    /// <summary>
    /// 实现服务契约业务类
    /// </summary>
    public class WcfDemoService : IWcfDemoService
    {
        /// <summary>
        /// 实现操作契约函数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
