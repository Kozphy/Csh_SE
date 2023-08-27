namespace SampleService;

public class DemoService
{
    public bool IsMoreThan2(int candidate)
    {
        if (candidate <= 2)
        {
            return false;
        }

        return true;
    }

}
