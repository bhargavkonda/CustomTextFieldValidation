using MudBlazor.Services;

namespace CustomTextFieldValidation;

public class CustomKeyInterceptorFactory : MudBlazor.Services.IKeyInterceptorFactory
{
    public IKeyInterceptor GetInterceptor() => new CustomKeyInterceptor();

    IKeyInterceptor IKeyInterceptorFactory.Create()
    {
        throw new NotImplementedException();
    }
}

public class CustomKeyInterceptor : IKeyInterceptor
{
    // Implement the interface methods as needed
    public event KeyboardEvent KeyDown;
    public event KeyboardEvent KeyUp;

    public Task Connect(string elementId, KeyInterceptorOptions options)
    {
        throw new NotImplementedException();
    }

    public Task Disconnect()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task UpdateKey(KeyOptions option)
    {
        throw new NotImplementedException();
    }
}