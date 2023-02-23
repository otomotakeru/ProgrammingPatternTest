using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Interface
{
    public interface IStanable
    {
        public float StanTime { get; set; }

        public void Stan();
    }
}