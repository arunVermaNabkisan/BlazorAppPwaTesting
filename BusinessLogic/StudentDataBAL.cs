namespace BusinessLogic;

public class StudentDataBAL
{
    public async Task<int[]> GetStudentDataAsync()
    {
        await Task.CompletedTask;
        return [2, 7, 9, 3];
    }
}