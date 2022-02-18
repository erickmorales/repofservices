import { Component, OnInit , OnDestroy} from '@angular/core';
import { CourseService } from '../course.service';
import { Course } from '../domain/course';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-list-estudiantes',
  templateUrl: './list-estudiantes.component.html',
  styleUrls: ['./list-estudiantes.component.scss']
})
export class ListEstudiantesComponent implements OnInit,OnDestroy {

  public courses: Course[];
  public subCourses: Subscription;
  constructor(public courseService: CourseService) { }
  ngOnDestroy(): void {
    this.subCourses.unsubscribe();
  }

  ngOnInit(): void {
  this.getAll();
  }

getAll(){
  this.subCourses=this.courseService.getAll().subscribe(data=>{
    this.courses= data;
  });

}

}
