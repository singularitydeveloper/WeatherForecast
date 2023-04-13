using WeatherForecastApi.Controllers;

namespace WeatherForecastApi.Test
{
    public class WeatherForecastTest
    {
        [Fact]
        public void GetTest()
        {
            //Arrange
            var weatherForecast = new WeatherForecastController();

            //Act
            var result = weatherForecast.Get();

            //Assert
            Assert.IsAssignableFrom<IEnumerable<WeatherForecast>>(result);
        }
    }
}