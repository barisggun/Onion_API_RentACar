using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CQRS.Commands.AboutCommands
{
    public class RemoveAboutCommand
    {
        public int Id { get; set; }
        public RemoveAboutCommand(int ıd)
        {
            Id = ıd;
        }

        //Çünkü remove işleminde bana bütün propertyler değil sadece id lazım.Constructor edilmiş ID


    }
}
