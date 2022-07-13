using WebApplicationAPI.Model;

namespace WebApplicationAPI.Service

{
    public interface IMathOperations
    {
        int AddFun(InputValues values);
        int SubFun(InputValues values);
        int MulFun(InputValues values);
        int DivFun(InputValues values);

    }
}
