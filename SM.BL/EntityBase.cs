using System;
namespace SM.BL.cs
{
    public enum EntityStateOption   //Base class to carry all the Entities to all other classes.
    {
        Active,
        Deleted
    }
    public abstract class EntityBase //abstract class
    {
        public EntityStateOption EntityState { get; set; } //prop
        public bool HasChanges { get; set; }               //prop
        public bool IsNew { get; private set; }            //propg
        public bool IsValid //or => Validate();
        {
            get { return Validate(); }
        }
        public abstract bool Validate();
        
    }
}

