using NUnit.Framework;
using RunLikeTheWind.Domain.Interfaces;

namespace RunLikeTheWind.Domain.Tests.Unit
{
    [TestFixture]
    public class WorkoutPlannerTests
    {
        private IWeather weather;
        private IWorkoutPlanner sut;


        [Test]
        public void CreateWorkoutPlan_StrongWindContitions_ReturnsPRAttempt()
        {
            weather = new Weather.Weather("N", Constants.StrongWindKmph, 22, "");
            sut = new WorkoutPlanner.WorkoutPlanner(weather);

            var workoutPlan = sut.CreateWorkoutPlan();

            Assert.AreEqual("Run a route that mainly heads North. Go break that PR.", workoutPlan);
        }

        [Test]
        public void CreateWorkoutPlan_LowWind_ReturnsTempoRun()
        {
            weather = new Weather.Weather("N", 5, 22, "");
            sut = new WorkoutPlanner.WorkoutPlanner(weather);

            var workoutPlan = sut.CreateWorkoutPlan();

            Assert.AreEqual("I suggest a 5K tempo run today", workoutPlan);
        }

        [Test]
        public void CreateWorkoutPlan_HighTemperature_ReturnsEasyRun()
        {
            weather = new Weather.Weather("N", 5, Constants.HighTemperatureCelcius, "");
            sut = new WorkoutPlanner.WorkoutPlanner(weather);

            var workoutPlan = sut.CreateWorkoutPlan();

            Assert.AreEqual("Very easy run only. Stay well hydrated", workoutPlan);
        }
    }
}