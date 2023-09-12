using System.Runtime.Serialization;

namespace DungeonMaster.Models.Exceptions
{
    [Serializable]
    internal class InvalidEquipmentException : Exception
    {
        public InvalidEquipmentException()
        {
        }

        public InvalidEquipmentException(string? message) : base(message)
        {
        }

        public InvalidEquipmentException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidEquipmentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}