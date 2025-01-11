import { useEffect, useState } from "react";
import { Book } from "../api/interfaces/book";
import { getAllBooks } from "../api/bookApiCalls";

export default function BookScreen() {
  const [books, setBooks] = useState<Book[]>([]);

  useEffect(() => {
    const fetchData = async () => {
      const books = await getAllBooks();
      setBooks(books);
    };
    fetchData().catch(console.error);
  }, []);

  return (
    <>
      <div>
        <h1>Book List</h1>
        {books.length === 0 ? (
          <p>No books available</p>
        ) : (
          <ul style={{ listStyleType: "none", padding: 0 }}>
            {books.map((book) => (
              <li
                key={book.id}
                style={{
                  marginBottom: "0.5rem",
                  padding: "0.5rem",
                  border: "1px solid #ccc",
                  borderRadius: "5px",
                }}
              >
                <strong>{book.title}</strong>
              </li>
            ))}
          </ul>
        )}
      </div>
    </>
  );
}
