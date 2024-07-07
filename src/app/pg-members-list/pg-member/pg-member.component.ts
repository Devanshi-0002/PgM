import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { PgMember, PgMembersService } from 'src/app/services/pg-members.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-pg-member',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './pg-member.component.html',
  styleUrls: ['./pg-member.component.scss']
})
export class PgMemberComponent implements OnInit {
  pgMemberForm: FormGroup;
  isEditMode = false;
  pgMemberId: string | null = null;

  constructor(
    private fb: FormBuilder,
    private pgMembersService: PgMembersService,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.pgMemberForm = this.fb.group({
      fullName: ['', Validators.required],
      mobileNumber: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      rentAmount: [0, Validators.required], // Corrected field name to match backend
      depositedAmount: [0, Validators.required],
      education: [''],
      jobCollegeOtherOption: [''],
      jobCollegeAddress: this.fb.group({
        addressLine1: ['', Validators.required],
        addressLine2: [''],
        pincode: ['', Validators.required],
        city: ['', Validators.required],
        state: ['', Validators.required]
      }),
      dateOfJoining: ['', Validators.required],
      permanentAddress: this.fb.group({
        addressLine1: ['', Validators.required],
        addressLine2: [''],
        pincode: ['', Validators.required],
        city: ['', Validators.required],
        state: ['', Validators.required]
      }),
      emergencyMobileNumber: ['', Validators.required],
      pgId: ['']
    });
  }

  ngOnInit(): void {
    this.pgMemberId = this.route.snapshot.paramMap.get('id');
    if (this.pgMemberId) {
      this.isEditMode = true;
      this.pgMembersService.getPgMember(this.pgMemberId).subscribe((data: PgMember) => {
        this.pgMemberForm.patchValue(data);
      });
    }
  }

  onSubmit(): void {
    debugger;
    // if (this.pgMemberForm.valid) {
      if (this.pgMemberId) {
        this.pgMembersService.updatePgMember(this.pgMemberId, this.pgMemberForm.value).subscribe(() => {
          this.router.navigate(['/pg-members']);
        });
      } else {
        this.pgMembersService.createPgMember(this.pgMemberForm.value).subscribe(() => {
          this.router.navigate(['/pg-members']);
        }, error => {
          console.error('Error creating PgMember:', error);
        });
      }
    // }
  }
}
