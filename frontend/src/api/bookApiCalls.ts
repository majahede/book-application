import { fetchHttp } from "./httpCalls";
import { Book } from "./interfaces/book";

export const getAllBooks = async (): Promise<Book[]> => {
  return await fetchHttp("book", "GET");
};
