using System;

namespace Library
{
    [Serializable]
    public class Member
    {
        public Member(string name)
        {
            this.Name = name;
            this.Id = _nextId++;
        }
        private static int _nextId = 1;
        public string Name { get; private set; }
        public int Id { get; private set; }
        public override string ToString()
        {
            return $"{Name} ({Id})";
        }
    }
}