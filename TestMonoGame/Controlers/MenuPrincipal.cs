using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMonoGame.mechanics {
    class MenuPrincipal {
        private ArrayList TextesMenus { get; set; }




        public MenuPrincipal() {
        TextesMenus = new ArrayList {
                new string[] { "Nouvelle Partie", "Options", "Quitter" },
                new string[] { "Graphiques", "Son", "Menu principal" }
            };



        }

    }
}
