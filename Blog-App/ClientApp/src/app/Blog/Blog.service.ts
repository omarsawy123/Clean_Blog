import { Injectable } from "@angular/core";
import { IBlog } from "./IBlog";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";



@Injectable()
export class BlogService {

  constructor(private http: HttpClient) {
   
  }
  

  getBlogs(): Observable<IBlog[]> {

    return this.http.get<IBlog[]>("https://localhost:44313/blogs");
    
  }

  getBlog(Id: string): Observable<IBlog> {
    return this.http.get<IBlog>("https://localhost:44313/blogs/"+Id)
  }

  postBlog(newBlog: IBlog): Observable<IBlog> {

    return this.http.post<IBlog>("https://localhost:44313/blogs", newBlog);
  }

  EditBlog(editedBlog: IBlog): Observable<IBlog> {

    return this.http.put<IBlog>("https://localhost:44313/blogs",editedBlog)
  }

  DeleteBlog(Id: string): Observable<void> {
    return this.http.delete<void>("https://localhost:44313/blogs/" + Id);
  }
  
}
