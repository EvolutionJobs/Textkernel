namespace Evolution.Textkernel
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface ITextkernelParser
    {
        Task<string> Parse(byte[] file);
    }
}
