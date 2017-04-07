using System.ServiceModel;

namespace IBLL
{
    /// <summary>
    /// 服务契约接口
    /// </summary>
    [ServiceContract]
    public interface IWcfDemoService
    {
        /// <summary>
        /// 一个操作契约
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [OperationContract]
        int Add(int a, int b);

    }
}
