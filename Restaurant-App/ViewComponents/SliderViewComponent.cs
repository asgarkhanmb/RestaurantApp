using Microsoft.AspNetCore.Mvc;
using Restaurant_App.Models;
using Restaurant_App.Services.Interfaces;

namespace Restaurant_App.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly ISliderService _sliderService;

        public SliderViewComponent(ISliderService sliderService)
        {

            _sliderService = sliderService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliderDatas = new SliderVMVC
            {
                Sliders = await _sliderService.GetAllAsync(),
            };

            return await Task.FromResult(View(sliderDatas));
        }

    }
    public class SliderVMVC
    {
        public IEnumerable<Slider> Sliders { get; set; }

    }
}
