namespace DOTNET___POO.src.Entities {
    public class Ninja : Hero{
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType){

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " - Lançou um Ninjutsu!";
        }

        public string Attack(int bonus){

            if (bonus > 6){
                return this.Name + " - Lançou um Ninjutsu super efetiva com bônus de " + bonus;
            }else{
                return this.Name + " - Lançou um Ninjutsu com força fraca com bônus de " + bonus;
            }
        }
    }  
}