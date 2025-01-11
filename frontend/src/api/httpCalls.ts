import axios, { Method } from "axios";

var apiUrl = "http://localhost:8080";

export const fetchHttp = async <TResponse, TPayload>(
  url: string,
  method: Method,
  reqBody?: TPayload
): Promise<TResponse> => {
  try {
    const response = await axios(`${apiUrl}/${url}`, {
      method: method,
      headers: { "content-type": "application/json" },
      data: {
        ...(reqBody && reqBody),
      },
    });
    console.log(response.data);
    return response.data;
  } catch (error) {
    throw new Error("Unknown server error");
  }
};
