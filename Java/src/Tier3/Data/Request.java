package Tier3.Data;

public class Request {
    private Object o;
    private requestOperationEnum requestOperation;
    private String Username;

    public Object getO() {
        return o;
    }

    public void setO(Object o) {
        this.o = o;
    }

    public requestOperationEnum getRequestOperation() {
        return requestOperation;
    }

    public void setRequestOperation(requestOperationEnum requestOperation) {
        this.requestOperation = requestOperation;
    }

    public String getUsername() {
        return Username;
    }

    public void setUsername(String username) {
        Username = username;
    }


}
