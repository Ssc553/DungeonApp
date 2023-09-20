using System.Reflection.Metadata.Ecma335;

namespace DungeonLibrary
{
    public class Character
    {// Field
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;
        private int _life;
       //Property 
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                _life = value;
                    
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }//end Life
        //CTOR
        public Character()
        {
             //default CTOR
        }
        public Character(string name, int hitChance, int block, int maxLife)
        {
            MaxLife = maxLife;
            Life = MaxLife;//start off with full health.
            Block = block;
            HitChance = hitChance;
            Name = name;
        }
        // Combat Methods
        public override string ToString()
        {
            //return base.ToString();
            return $"----- {Name} -----\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Block}%";
        }
        public int CalcBlock()
        {
            return Block;
        }
        public int CalcHitChance()
        {
            return HitChance;
        }
        public int CalcDamage()
        {
            return 0;
        }
        //Combat Methods

    }//end class
}//end namespace