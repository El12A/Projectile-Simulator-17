using TMPro;
using UnityEngine;
namespace PhysicsProjectileSimulator
{
    public class MissingSuvatTextController : VariableController
    {
        // Start is called before the first frame update
        [SerializeField] private TMP_Text text1;
        [SerializeField] private TMP_Text text2;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void UpdateVariableText()
        {
            text1.text = variableController.unselectedVariables[0];
            text2.text = variableController.unselectedVariables[1];
        }

        public void UpdateAllText()
        {
            string variable1 = variableController.unselectedVariables[0];
            string variable2 = variableController.unselectedVariables[1];
            findMissingSuvat.CalculateMissingVariables();
            text1.text = variable1 + "<br>" + GetVarValue(variable1);
            text2.text = variable2 + "<br>" + GetVarValue(variable2);
        }

        private string GetVarValue(string var)
        {
            if (var == "Initial Velocity")
            {
                string Value = "X:" + RoundToSF(variableController.initialVelocity.x, 3) + " Y:" + RoundToSF(variableController.initialVelocity.y, 3) + " Z:" + RoundToSF(variableController.initialVelocity.z, 3);
                return Value;
            }
            else if (var == "Final Velocity")
            {
                string Value = "X:" + RoundToSF(variableController.finalVelocity.x, 3) + " Y:" + RoundToSF(variableController.finalVelocity.y, 3) + " Z:" + RoundToSF(variableController.finalVelocity.z, 3);
                return Value;
            }
            else if (var == "Displacement")
            {
                string Value = "X:" + RoundToSF(variableController.displacement.x, 3) + " Y:" + RoundToSF(variableController.displacement.y, 3) + " Z:" + RoundToSF(variableController.displacement.z, 3);
                return Value;
            }
            else if (var == "Acceleration")
            {
                string Value = "X:" + RoundToSF(variableController.acceleration.x, 3) + " Y:" + RoundToSF(variableController.acceleration.y, 3) + " Z:" + RoundToSF(variableController.acceleration.z, 3);
                return Value;
            }
            else if (var == "Time")
            {
                string Value = "X:" + RoundToSF(variableController.time.x, 3) + " Y:" + RoundToSF(variableController.time.y, 3) + " Z:" + RoundToSF(variableController.time.z, 3);
                return Value;
            }
            return "";
        }
    }
}

