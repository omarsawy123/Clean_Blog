// This Component is used to Create New Blogs

import { Component, OnInit } from "@angular/core";
import { async } from "@angular/core/testing";
import { NgForm } from "@angular/forms";
import { IBlog } from "../Blog/IBlog";
import { BlogService } from "../Blog/Blog.service";
import { Router } from "@angular/router";
import { formatDate } from "@angular/common";




@Component({
  selector: "createBlog",
  templateUrl: "./CreateBlog.component.html",

  

})

export class CreateBlogComponent implements OnInit {

  blog: IBlog;
  blogs: IBlog[];
  myDate = formatDate(new Date(), 'yyyy/MM/dd', 'en');

  buttonText: string = "Post";
  HeaderText: string = "Create Blog";


  

  constructor(private _blogservice: BlogService, private _router: Router,) {}

  ngOnInit() {

    this.blog = {
      id:null,
      name: null,
      AuthorId: null,
      category: null,
      content: null,
      datePublished: null
    }

    this._blogservice.getBlogs().subscribe(data => this.blogs = data);

  }

  //Create BLog

  saveBlog(newBlog: IBlog) {

    if (newBlog.id == null) {


      newBlog.id = (Number(this.blogs[this.blogs.length - 1].id) + 1).toString();

      newBlog.datePublished = this.myDate.toString();

      this._blogservice.postBlog(newBlog).subscribe(data => this.blogs.push(newBlog));

      this._router.navigate(["/blog"]).then(() => {
        window.location.reload();
      });

    }

    
   
  }

}
