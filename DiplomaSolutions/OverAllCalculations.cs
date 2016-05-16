namespace DiplomaSolutions
{
    public class OverAllCalculations
    {
        public CalculatedData calculatedData;
        public CalculationGeometricParams firstCalculation;
        public CalculationControls fourthCalculation;
        public InputData inputData;
        public CalculationDiameters secondCalculation;
        public CalculationWormDimensions thirdCalculation;

        public OverAllCalculations(CalculatedData calculatedData, InputData inputData)
        {
            this.calculatedData = calculatedData;
            this.inputData = inputData;
        }

        public void initializeCalcFunctions()
        {
            firstCalculation = new CalculationGeometricParams(inputData, calculatedData);
            secondCalculation = new CalculationDiameters(inputData, calculatedData);
            thirdCalculation = new CalculationWormDimensions(calculatedData, inputData);
            fourthCalculation = new CalculationControls(inputData, calculatedData);
        }

        public void initializeCalculations()
        {
            firstCalculation.invokeCalculations();
            secondCalculation.invokeCalculations();
            thirdCalculation.invokeCalculations();
            fourthCalculation.invokeCalculations();
        }

    }
}