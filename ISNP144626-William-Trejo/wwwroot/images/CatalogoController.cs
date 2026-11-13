using Microsoft.AspNetCore.Mvc;
using ISNP144626_William_Trejo.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ISNP144626_William_Trejo.wwwroot.imagenes
{
    public class CatalogoController : Controller
    {
        private static List<Videojuego> _lista = new List<Videojuego>
        {
            // ================= PLAYSTATION 5 (1 al 20) =================
            new Videojuego { Id=1, Titulo="Marvel's Spider-Man 2", Categoria="PlayStation 5", Descripcion="Acción y balanceo en NY.", ImagenUrl="~/images/spiderman2.jpg" },
            new Videojuego { Id=2, Titulo="God of War Ragnarök", Categoria="PlayStation 5", Descripcion="La épica conclusión nórdica.", ImagenUrl="~/images/gow_ragnarok.jpg" },
            new Videojuego { Id=3, Titulo="Demon's Souls", Categoria="PlayStation 5", Descripcion="Remake del clásico y desafiante RPG.", ImagenUrl="~/images/demons_souls.jpg" },
            new Videojuego { Id=4, Titulo="Ratchet & Clank: Rift Apart", Categoria="PlayStation 5", Descripcion="Aventura interdimensional next-gen.", ImagenUrl="~/images/ratchet.jpg" },
            new Videojuego { Id=5, Titulo="Returnal", Categoria="PlayStation 5", Descripcion="Shooter roguelike de ciencia ficción.", ImagenUrl="~/images/returnal.jpg" },
            new Videojuego { Id=6, Titulo="Horizon Forbidden West", Categoria="PlayStation 5", Descripcion="Explora un mundo post-apocalíptico.", ImagenUrl="~/images/horizon_fw.jpg" },
            new Videojuego { Id=7, Titulo="Final Fantasy XVI", Categoria="PlayStation 5", Descripcion="RPG de acción con combates masivos.", ImagenUrl="~/images/ff16.jpg" },
            new Videojuego { Id=8, Titulo="Gran Turismo 7", Categoria="PlayStation 5", Descripcion="Simulador de conducción realista.", ImagenUrl="~/images/gt7.jpg" },
            new Videojuego { Id=9, Titulo="Stellar Blade", Categoria="PlayStation 5", Descripcion="Combate hack and slash estilizado.", ImagenUrl="~/images/stellar_blade.jpg" },
            new Videojuego { Id=10, Titulo="Rise of the Ronin", Categoria="PlayStation 5", Descripcion="Acción en el Japón del siglo XIX.", ImagenUrl="~/images/ronin.jpg" },
            new Videojuego { Id=11, Titulo="Astro Bot", Categoria="PlayStation 5", Descripcion="Plataformas creativo y divertido.", ImagenUrl="~/images/astro_bot.jpg" },
            new Videojuego { Id=12, Titulo="Deathloop", Categoria="PlayStation 5", Descripcion="Bucle temporal de disparos y sigilo.", ImagenUrl="~/images/deathloop.jpg" },
            new Videojuego { Id=13, Titulo="Ghostwire: Tokyo", Categoria="PlayStation 5", Descripcion="Misterio paranormal en primera persona.", ImagenUrl="~/images/ghostwire.jpg" },
            new Videojuego { Id=14, Titulo="Helldivers 2", Categoria="PlayStation 5", Descripcion="Guerra galáctica cooperativa.", ImagenUrl="~/images/helldivers2.jpg" },
            new Videojuego { Id=15, Titulo="The Last of Us Part I", Categoria="PlayStation 5", Descripcion="Remake del clásico de supervivencia.", ImagenUrl="~/images/tlou1.jpg" },
            new Videojuego { Id=16, Titulo="Kena: Bridge of Spirits", Categoria="PlayStation 5", Descripcion="Aventura mágica con gran apartado visual.", ImagenUrl="~/images/kena.jpg" },
            new Videojuego { Id=17, Titulo="Forspoken", Categoria="PlayStation 5", Descripcion="Parkour mágico y exploración.", ImagenUrl="~/images/forspoken.jpg" },
            new Videojuego { Id=18, Titulo="Sackboy: A Big Adventure", Categoria="PlayStation 5", Descripcion="Plataformas 3D cooperativo.", ImagenUrl="~/images/sackboy.jpg" },
            new Videojuego { Id=19, Titulo="Destruction AllStars", Categoria="PlayStation 5", Descripcion="Combate de vehículos frenético.", ImagenUrl="~/images/destruction.jpg" },
            new Videojuego { Id=20, Titulo="Silent Hill 2 Remake", Categoria="PlayStation 5", Descripcion="Terror psicológico de nueva generación.", ImagenUrl="~/images/silenthill2.jpg" },

            // ================= PLAYSTATION 4 (21 al 40) =================
            new Videojuego { Id=21, Titulo="Bloodborne", Categoria="PlayStation 4", Descripcion="Obra maestra del terror gótico.", ImagenUrl="~/images/bloodborne.jpg" },
            new Videojuego { Id=22, Titulo="Uncharted 4", Categoria="PlayStation 4", Descripcion="La última aventura de Nathan Drake.", ImagenUrl="~/images/uncharted4.jpg" },
            new Videojuego { Id=23, Titulo="The Last of Us Part II", Categoria="PlayStation 4", Descripcion="Secuela intensa y emocional.", ImagenUrl="~/images/tlou2.jpg" },
            new Videojuego { Id=24, Titulo="Ghost of Tsushima", Categoria="PlayStation 4", Descripcion="Samuráis en un mundo abierto hermoso.", ImagenUrl="~/images/tsushima.jpg" },
            new Videojuego { Id=25, Titulo="God of War (2018)", Categoria="PlayStation 4", Descripcion="El reinicio de la saga nórdica.", ImagenUrl="~/images/gow2018.jpg" },
            new Videojuego { Id=26, Titulo="Marvel's Spider-Man", Categoria="PlayStation 4", Descripcion="Aventura de superhéroes aclamada.", ImagenUrl="~/images/spiderman_ps4.jpg" },
            new Videojuego { Id=27, Titulo="Horizon Zero Dawn", Categoria="PlayStation 4", Descripcion="Caza de máquinas en el futuro.", ImagenUrl="~/images/horizon_hzd.jpg" },
            new Videojuego { Id=28, Titulo="Persona 5 Royal", Categoria="PlayStation 4", Descripcion="JRPG de estilo único.", ImagenUrl="~/images/persona5.jpg" },
            new Videojuego { Id=29, Titulo="inFAMOUS Second Son", Categoria="PlayStation 4", Descripcion="Superpoderes en Seattle.", ImagenUrl="~/images/infamous.jpg" },
            new Videojuego { Id=30, Titulo="Days Gone", Categoria="PlayStation 4", Descripcion="Supervivencia en moto contra hordas.", ImagenUrl="~/images/daysgone.jpg" },
            new Videojuego { Id=31, Titulo="Detroit: Become Human", Categoria="PlayStation 4", Descripcion="Narrativa interactiva sobre androides.", ImagenUrl="~/images/detroit.jpg" },
            new Videojuego { Id=32, Titulo="Shadow of the Colossus", Categoria="PlayStation 4", Descripcion="Remake del clásico monumental.", ImagenUrl="~/images/sotc.jpg" },
            new Videojuego { Id=33, Titulo="The Last Guardian", Categoria="PlayStation 4", Descripcion="Aventura con una criatura gigante.", ImagenUrl="~/images/lastguardian.jpg" },
            new Videojuego { Id=34, Titulo="Until Dawn", Categoria="PlayStation 4", Descripcion="Terror adolescente de decisiones.", ImagenUrl="~/images/untildawn.jpg" },
            new Videojuego { Id=35, Titulo="Gran Turismo Sport", Categoria="PlayStation 4", Descripcion="Competencia automovilística online.", ImagenUrl="~/images/gtsport.jpg" },
            new Videojuego { Id=36, Titulo="Killzone Shadow Fall", Categoria="PlayStation 4", Descripcion="Shooter futurista táctico.", ImagenUrl="~/images/killzone.jpg" },
            new Videojuego { Id=37, Titulo="Knack 2", Categoria="PlayStation 4", Descripcion="Plataformas y combates familiares.", ImagenUrl="~/images/knack2.jpg" },
            new Videojuego { Id=38, Titulo="Driveclub", Categoria="PlayStation 4", Descripcion="Carreras arcade con gráficos impresionantes.", ImagenUrl="~/images/driveclub.jpg" },
            new Videojuego { Id=39, Titulo="Gravity Rush 2", Categoria="PlayStation 4", Descripcion="Control de la gravedad en mundo abierto.", ImagenUrl="~/images/gravityrush2.jpg" },
            new Videojuego { Id=40, Titulo="Tearaway Unfolded", Categoria="PlayStation 4", Descripcion="Aventura creativa de papel.", ImagenUrl="~/images/tearaway.jpg" },

            // ================= NINTENDO SWITCH (41 al 60) =================
            new Videojuego { Id=41, Titulo="The Legend of Zelda: BOTW", Categoria="Nintendo Switch", Descripcion="Revolución del mundo abierto.", ImagenUrl="~/images/botw.jpg" },
            new Videojuego { Id=42, Titulo="The Legend of Zelda: TOTK", Categoria="Nintendo Switch", Descripcion="Secuela con construcción creativa.", ImagenUrl="~/images/totk.jpg" },
            new Videojuego { Id=43, Titulo="Super Mario Odyssey", Categoria="Nintendo Switch", Descripcion="Aventura 3D global de Mario.", ImagenUrl="~/images/mario_odyssey.jpg" },
            new Videojuego { Id=44, Titulo="Super Smash Bros. Ultimate", Categoria="Nintendo Switch", Descripcion="El crossover de peleas definitivo.", ImagenUrl="~/images/smash.jpg" },
            new Videojuego { Id=45, Titulo="Mario Kart 8 Deluxe", Categoria="Nintendo Switch", Descripcion="Carreras perfectas para multijugador.", ImagenUrl="~/images/mariokart8.jpg" },
            new Videojuego { Id=46, Titulo="Animal Crossing: New Horizons", Categoria="Nintendo Switch", Descripcion="Vida pacífica en tu propia isla.", ImagenUrl="~/images/animalcrossing.jpg" },
            new Videojuego { Id=47, Titulo="Splatoon 3", Categoria="Nintendo Switch", Descripcion="Guerras de pintura competitivas.", ImagenUrl="~/images/splatoon3.jpg" },
            new Videojuego { Id=48, Titulo="Metroid Dread", Categoria="Nintendo Switch", Descripcion="Acción y exploración 2D tensa.", ImagenUrl="~/images/metroid_dread.jpg" },
            new Videojuego { Id=49, Titulo="Luigi's Mansion 3", Categoria="Nintendo Switch", Descripcion="Caza de fantasmas en un hotel.", ImagenUrl="~/images/luigimansion3.jpg" },
            new Videojuego { Id=50, Titulo="Xenoblade Chronicles 3", Categoria="Nintendo Switch", Descripcion="RPG de escala masiva.", ImagenUrl="~/images/xenoblade3.jpg" },
            new Videojuego { Id=51, Titulo="Fire Emblem Engage", Categoria="Nintendo Switch", Descripcion="Estrategia táctica por turnos.", ImagenUrl="~/images/fireemblem.jpg" },
            new Videojuego { Id=52, Titulo="Pokémon Escarlata", Categoria="Nintendo Switch", Descripcion="Mundo abierto Pokémon.", ImagenUrl="~/images/pokemon_escarlata.jpg" },
            new Videojuego { Id=53, Titulo="Super Mario Bros. Wonder", Categoria="Nintendo Switch", Descripcion="Plataformas 2D con efectos mágicos.", ImagenUrl="~/images/mario_wonder.jpg" },
            new Videojuego { Id=54, Titulo="Pikmin 4", Categoria="Nintendo Switch", Descripcion="Estrategia con criaturas vegetales.", ImagenUrl="~/images/pikmin4.jpg" },
            new Videojuego { Id=55, Titulo="Kirby y la Tierra Olvidada", Categoria="Nintendo Switch", Descripcion="Aventura 3D colorida.", ImagenUrl="~/images/kirby3d.jpg" },
            new Videojuego { Id=56, Titulo="Donkey Kong Tropical Freeze", Categoria="Nintendo Switch", Descripcion="Plataformas desafiante.", ImagenUrl="~/images/dk_tropical.jpg" },
            new Videojuego { Id=57, Titulo="Astral Chain", Categoria="Nintendo Switch", Descripcion="Acción frenética.", ImagenUrl="~/images/astralchain.jpg" },
            new Videojuego { Id=58, Titulo="Bayonetta 3", Categoria="Nintendo Switch", Descripcion="Combates brujos excesivos.", ImagenUrl="~/images/bayonetta3.jpg" },
            new Videojuego { Id=59, Titulo="Mario Party Superstars", Categoria="Nintendo Switch", Descripcion="Minijuegos clásicos.", ImagenUrl="~/images/marioparty.jpg" },
            new Videojuego { Id=60, Titulo="Paper Mario: The Origami King", Categoria="Nintendo Switch", Descripcion="RPG con batallas de anillos.", ImagenUrl="~/images/papermario.jpg" },

            // ================= NINTENDO SWITCH 2 (61 al 80) =================
            new Videojuego { Id=61, Titulo="Metroid Prime 4: Beyond", Categoria="Nintendo Switch 2", Descripcion="El esperado regreso de Samus.", ImagenUrl="~/images/metroid4.jpg" },
            new Videojuego { Id=62, Titulo="Super Mario Universe", Categoria="Nintendo Switch 2", Descripcion="Próxima gran aventura 3D.", ImagenUrl="~/images/mario_universe.jpg" },
            new Videojuego { Id=63, Titulo="Mario Kart 9 / Crossroads", Categoria="Nintendo Switch 2", Descripcion="La nueva era de carreras.", ImagenUrl="~/images/mariokart9.jpg" },
            new Videojuego { Id=64, Titulo="Zelda Ocarina of Time Remake", Categoria="Nintendo Switch 2", Descripcion="Remake del clásico.", ImagenUrl="~/images/zelda_oot.jpg" },
            new Videojuego { Id=65, Titulo="Super Smash Bros. Next", Categoria="Nintendo Switch 2", Descripcion="Nueva generación de combates.", ImagenUrl="~/images/smash_next.jpg" },
            new Videojuego { Id=66, Titulo="Pokémon Gen 10", Categoria="Nintendo Switch 2", Descripcion="Décima generación de monstruos.", ImagenUrl="~/images/pokemon_gen10.jpg" },
            new Videojuego { Id=67, Titulo="Xenoblade Chronicles 4", Categoria="Nintendo Switch 2", Descripcion="Continuación del RPG de Monolith.", ImagenUrl="~/images/xenoblade4.jpg" },
            new Videojuego { Id=68, Titulo="Splatoon 4", Categoria="Nintendo Switch 2", Descripcion="Nuevas armas competitivas.", ImagenUrl="~/images/splatoon4.jpg" },
            new Videojuego { Id=69, Titulo="Animal Crossing Next", Categoria="Nintendo Switch 2", Descripcion="Simulación de vida avanzada.", ImagenUrl="~/images/animalcrossing2.jpg" },
            new Videojuego { Id=70, Titulo="Luigi's Mansion 4", Categoria="Nintendo Switch 2", Descripcion="Más fantasmas y gráficos.", ImagenUrl="~/images/luigimansion4.jpg" },
            new Videojuego { Id=71, Titulo="Star Fox Armada", Categoria="Nintendo Switch 2", Descripcion="Combate espacial a 60fps.", ImagenUrl="~/images/starfox.jpg" },
            new Videojuego { Id=72, Titulo="F-Zero NX", Categoria="Nintendo Switch 2", Descripcion="Velocidad futurista extrema.", ImagenUrl="~/images/fzero.jpg" },
            new Videojuego { Id=73, Titulo="Kid Icarus Uprising 2", Categoria="Nintendo Switch 2", Descripcion="Acción divina en HD.", ImagenUrl="~/images/kidicarus2.jpg" },
            new Videojuego { Id=74, Titulo="Pikmin 5", Categoria="Nintendo Switch 2", Descripcion="Nuevos desafíos estratégicos.", ImagenUrl="~/images/pikmin5.jpg" },
            new Videojuego { Id=75, Titulo="Fire Emblem Next", Categoria="Nintendo Switch 2", Descripcion="Guerra y táctica renovadas.", ImagenUrl="~/images/fireemblem2.jpg" },
            new Videojuego { Id=76, Titulo="Donkey Kong 3D", Categoria="Nintendo Switch 2", Descripcion="El gorila en mundo abierto.", ImagenUrl="~/images/dk3d.jpg" },
            new Videojuego { Id=77, Titulo="WarioWare Ultra", Categoria="Nintendo Switch 2", Descripcion="Minijuegos con nuevos joy-cons.", ImagenUrl="~/images/warioware.jpg" },
            new Videojuego { Id=78, Titulo="Golden Sun Remake", Categoria="Nintendo Switch 2", Descripcion="El clásico RPG retorna.", ImagenUrl="~/images/goldensun.jpg" },
            new Videojuego { Id=79, Titulo="Bayonetta 4", Categoria="Nintendo Switch 2", Descripcion="La bruja vuelve más poderosa.", ImagenUrl="~/images/bayonetta4.jpg" },
            new Videojuego { Id=80, Titulo="Monolith Soft Action Game", Categoria="Nintendo Switch 2", Descripcion="Nueva IP de acción.", ImagenUrl="~/images/monolith.jpg" },

            // ================= XBOX 360 (81 al 100) =================
            new Videojuego { Id=81, Titulo="Halo 3", Categoria="Xbox 360", Descripcion="Cierre de la trilogía original.", ImagenUrl="~/images/halo3.jpg" },
            new Videojuego { Id=82, Titulo="Halo: Reach", Categoria="Xbox 360", Descripcion="La caída del escuadrón Noble.", ImagenUrl="~/images/halo_reach.jpg" },
            new Videojuego { Id=83, Titulo="Gears of War 2", Categoria="Xbox 360", Descripcion="Acción cooperativa inolvidable.", ImagenUrl="~/images/gow2.jpg" },
            new Videojuego { Id=84, Titulo="Gears of War 3", Categoria="Xbox 360", Descripcion="El clímax de la guerra Locust.", ImagenUrl="~/images/gow3.jpg" },
            new Videojuego { Id=85, Titulo="Fable II", Categoria="Xbox 360", Descripcion="RPG de decisiones morales.", ImagenUrl="~/images/fable2.jpg" },
            new Videojuego { Id=86, Titulo="Fable III", Categoria="Xbox 360", Descripcion="Conviértete en rey de Albion.", ImagenUrl="~/images/fable3.jpg" },
            new Videojuego { Id=87, Titulo="Forza Horizon", Categoria="Xbox 360", Descripcion="Nacimiento del festival de carreras.", ImagenUrl="~/images/forza_horizon1.jpg" },
            new Videojuego { Id=88, Titulo="Forza Motorsport 4", Categoria="Xbox 360", Descripcion="Simulación de automovilismo perfecta.", ImagenUrl="~/images/forza4.jpg" },
            new Videojuego { Id=89, Titulo="Alan Wake", Categoria="Xbox 360", Descripcion="Terror psicológico de Remedy.", ImagenUrl="~/images/alanwake.jpg" },
            new Videojuego { Id=90, Titulo="Crackdown", Categoria="Xbox 360", Descripcion="Acción policial con superpoderes.", ImagenUrl="~/images/crackdown.jpg" },
            new Videojuego { Id=91, Titulo="Mass Effect 2", Categoria="Xbox 360", Descripcion="RPG espacial definitivo.", ImagenUrl="~/images/masseffect2.jpg" },
            new Videojuego { Id=92, Titulo="Lost Odyssey", Categoria="Xbox 360", Descripcion="JRPG épico de Hironobu Sakaguchi.", ImagenUrl="~/images/lostodyssey.jpg" },
            new Videojuego { Id=93, Titulo="Blue Dragon", Categoria="Xbox 360", Descripcion="Rol con arte de Akira Toriyama.", ImagenUrl="~/images/bluedragon.jpg" },
            new Videojuego { Id=94, Titulo="Kameo", Categoria="Xbox 360", Descripcion="Magia y transformación de Rare.", ImagenUrl="~/images/kameo.jpg" },
            new Videojuego { Id=95, Titulo="Perfect Dark Zero", Categoria="Xbox 360", Descripcion="Shooter clásico de lanzamiento.", ImagenUrl="~/images/perfectdark.jpg" },
            new Videojuego { Id=96, Titulo="Viva Piñata", Categoria="Xbox 360", Descripcion="Gestión de jardín colorida y adictiva.", ImagenUrl="~/images/vivapinata.jpg" },
            new Videojuego { Id=97, Titulo="Left 4 Dead 2", Categoria="Xbox 360", Descripcion="Supervivencia zombi cooperativa.", ImagenUrl="~/images/l4d2.jpg" },
            new Videojuego { Id=98, Titulo="Dead Rising", Categoria="Xbox 360", Descripcion="Locura en centro comercial zombi.", ImagenUrl="~/images/deadrising.jpg" },
            new Videojuego { Id=99, Titulo="Project Gotham Racing 4", Categoria="Xbox 360", Descripcion="Carreras arcade callejeras.", ImagenUrl="~/images/pgr4.jpg" },
            new Videojuego { Id=100, Titulo="Banjo-Kazooie: Nuts & Bolts", Categoria="Xbox 360", Descripcion="Construcción de vehículos.", ImagenUrl="~/images/banjo.jpg" },

            // ================= XBOX CLÁSICA (101 al 120) =================
            new Videojuego { Id=101, Titulo="Halo: Combat Evolved", Categoria="Xbox Clásica", Descripcion="El inicio de la leyenda del Master Chief.", ImagenUrl="~/images/halo1.jpg" },
            new Videojuego { Id=102, Titulo="Halo 2", Categoria="Xbox Clásica", Descripcion="Revolucionó el multijugador online.", ImagenUrl="~/images/halo2.jpg" },
            new Videojuego { Id=103, Titulo="Fable", Categoria="Xbox Clásica", Descripcion="El RPG original que inició la saga.", ImagenUrl="~/images/fable1.jpg" },
            new Videojuego { Id=104, Titulo="Ninja Gaiden Black", Categoria="Xbox Clásica", Descripcion="Hack and slash implacable.", ImagenUrl="~/images/ninjagaiden.jpg" },
            new Videojuego { Id=105, Titulo="Forza Motorsport", Categoria="Xbox Clásica", Descripcion="El comienzo de la simulación.", ImagenUrl="~/images/forza1.jpg" },
            new Videojuego { Id=106, Titulo="Star Wars: KOTOR", Categoria="Xbox Clásica", Descripcion="El mejor RPG espacial.", ImagenUrl="~/images/kotor.jpg" },
            new Videojuego { Id=107, Titulo="Jade Empire", Categoria="Xbox Clásica", Descripcion="Artes marciales míticas de BioWare.", ImagenUrl="~/images/jadeempire.jpg" },
            new Videojuego { Id=108, Titulo="Crimson Skies", Categoria="Xbox Clásica", Descripcion="Combate aéreo en 1930 alternativo.", ImagenUrl="~/images/crimson.jpg" },
            new Videojuego { Id=109, Titulo="Panzer Dragoon Orta", Categoria="Xbox Clásica", Descripcion="Shooter sobre rieles increíble.", ImagenUrl="~/images/panzerdragoon.jpg" },
            new Videojuego { Id=110, Titulo="Project Gotham Racing 2", Categoria="Xbox Clásica", Descripcion="Carreras de alto nivel.", ImagenUrl="~/images/pgr2.jpg" },
            new Videojuego { Id=111, Titulo="Conker: Live & Reloaded", Categoria="Xbox Clásica", Descripcion="Humor para adultos y disparos.", ImagenUrl="~/images/conker.jpg" },
            new Videojuego { Id=112, Titulo="Splinter Cell: Chaos Theory", Categoria="Xbox Clásica", Descripcion="Cúspide del sigilo táctico.", ImagenUrl="~/images/splintercell.jpg" },
            new Videojuego { Id=113, Titulo="MechAssault", Categoria="Xbox Clásica", Descripcion="Batallas de mechas destructivas.", ImagenUrl="~/images/mechassault.jpg" },
            new Videojuego { Id=114, Titulo="Shenmue II", Categoria="Xbox Clásica", Descripcion="Aventura de venganza en HK.", ImagenUrl="~/images/shenmue2.jpg" },
            new Videojuego { Id=115, Titulo="Jet Set Radio Future", Categoria="Xbox Clásica", Descripcion="Patinaje urbano y música.", ImagenUrl="~/images/jsrf.jpg" },
            new Videojuego { Id=116, Titulo="Dead or Alive 3", Categoria="Xbox Clásica", Descripcion="Lucha 3D rompedora.", ImagenUrl="~/images/doa3.jpg" },
            new Videojuego { Id=117, Titulo="Blinx: The Time Sweeper", Categoria="Xbox Clásica", Descripcion="Manejo del tiempo y plataformas.", ImagenUrl="~/images/blinx.jpg" },
            new Videojuego { Id=118, Titulo="Burnout 3: Takedown", Categoria="Xbox Clásica", Descripcion="Accidentes y velocidad extrema.", ImagenUrl="~/images/burnout3.jpg" },
            new Videojuego { Id=119, Titulo="The Chronicles of Riddick", Categoria="Xbox Clásica", Descripcion="Fuga de prisión en 1ra persona.", ImagenUrl="~/images/riddick.jpg" },
            new Videojuego { Id=120, Titulo="Psychonauts", Categoria="Xbox Clásica", Descripcion="Plataformas en la mente humana.", ImagenUrl="~/images/psychonauts.jpg" }
        };

        // Método Index con filtro por categoría y mezcla aleatoria para el catálogo general
        public IActionResult Index(string categoria)
        {
            var query = _lista.AsEnumerable();

            if (!string.IsNullOrEmpty(categoria))
            {
                query = query.Where(j => j.Categoria.Contains(categoria, StringComparison.OrdinalIgnoreCase));
                return View(query.ToList());
            }
            else
            {
                var listaMezclada = query.OrderBy(x => Guid.NewGuid()).ToList();
                return View(listaMezclada);
            }
        }
    }
}