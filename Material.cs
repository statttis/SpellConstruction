using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellConstruction
{
    public class Material
    {
        public IFormLink<IBookGetter> Book { get; set; }

        public List<IFormLink<IItemGetter>> Materials { get; set; } = new List<IFormLink<IItemGetter>>();
    }
}
