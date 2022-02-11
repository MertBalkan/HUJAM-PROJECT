using UnityEngine;

namespace HUJAM1.Abstracts.Controllers
{
    public interface IEntityController
    {
        Transform transform { get; }
        float MoveSpeed { get; }
    }
}