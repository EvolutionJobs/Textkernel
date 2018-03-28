namespace Evolution.Textkernel
{
    using Evolution.Textkernel.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface ITextkernelParser
    {
        Task<Profile> Parse(byte[] file);
    }
}
