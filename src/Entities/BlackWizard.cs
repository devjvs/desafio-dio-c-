namespace DOTNET___POO.src.Entities
{
    public class BlackWizard : Hero {

        public BlackWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType){

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        
        public override string Attack(){
            return this.Name + " - Lançou Magia Negra!";
        }

        public string Attack(int bonus){

            if (bonus > 6){
                return this.Name + " - Lançou magia negra super efetiva com bônus de " + bonus;
            }else{
                return this.Name + " - Lançou uma magia negra com força fraca com bônus de " + bonus;
            }
        
    }
}
}