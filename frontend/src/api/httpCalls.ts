import axios, { Method } from "axios";

var apiUrl = process.env.REACT_APP_API_URL;

export const fetchHttp = async <TResponse, TPayload>(
  endpoint: string,
  method: Method,
  reqBody?: TPayload
): Promise<TResponse> => {
  try {
    const response = await axios(`${apiUrl}/${endpoint}`, {
      method: method,
      headers: { "content-type": "application/json" },
      data: {
        ...(reqBody && reqBody),
      },
    });
    return response.data;
  } catch (error) {
    throw new Error("Unknown server error");
  }
};
