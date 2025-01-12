import { useEffect, useState } from "react";
import { Book } from "../api/interfaces/book";
import { getAllBooks } from "../api/bookApiCalls";

export default function BookScreen() {
  const [books, setBooks] = useState<Book[]>([]);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const books = await getAllBooks();
        setBooks(books);
      } catch (err) {
        setError("Services are not available");
      }
    };

    fetchData();
  }, []);

  return (
    <>
      <div>
        <h1>Books</h1>
        {error ? (
          <p>{error}</p>
        ) : (
          <ul style={{ listStyleType: "none", padding: 0 }}>
            {books.map((book) => (
              <li
                key={book.id}
                style={{
                  padding: "0.5rem",
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
