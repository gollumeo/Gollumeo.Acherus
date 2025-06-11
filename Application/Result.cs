namespace Application;

public class Result<T>
{
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public T Value { get; }
    public string Error { get; }

    public Result(bool isSuccess, string error, T value)
    {
        IsSuccess = isSuccess;
        Error = error;
        Value = value;
    }
    
    public static Result<T> Success(T value) => new(true, string.Empty, value);
    public static Result<T> Failure(string error) => new(false, error, default!);
    
    public TResult Match<TResult>(Func<T, TResult> onSuccess, Func<string, TResult> onFailure)
        => IsSuccess ? onSuccess(Value!) : onFailure(Error);
}


public class Result : Result<object>
{
    private Result(bool isSuccess, string error)
        : base(isSuccess, error, new object()) { }

    public static Result Success() => new(true, string.Empty);
    public new static Result Failure(string error) => new(false, error);
}