using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Fomema.DAL.DBEntities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Fomema.DAL.DBContexts
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
        {
        }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Designation> Designation { get; set; }
        public virtual DbSet<Fileupload> Fileupload { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Holidaygroup> Holidaygroup { get; set; }
        public virtual DbSet<Jobgrade> Jobgrade { get; set; }
        public virtual DbSet<Maritalstatus> Maritalstatus { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Menurolemapping> Menurolemapping { get; set; }
        public virtual DbSet<Ottype> Ottype { get; set; }
        public virtual DbSet<Probation> Probation { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Registration1> Registration1 { get; set; }
        public virtual DbSet<RestDay> RestDay { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Status1> Status1 { get; set; }
        public virtual DbSet<WorkingHoursShift> WorkingHoursShift { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=20.68.215.183,49170;user id=ehartaadmin; password=Avows@2023;Database=Fomema_HR;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department", "employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.ToTable("designation", "employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Fileupload>(entity =>
            {
                entity.ToTable("fileupload", "timesheet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.Guidfilename)
                    .HasColumnName("guidfilename")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimesheetId).HasColumnName("timesheet_id");

                entity.HasOne(d => d.Timesheet)
                    .WithMany(p => p.Fileupload)
                    .HasForeignKey(d => d.TimesheetId)
                    .HasConstraintName("FK__fileuploa__times__6754599E");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("gender", "employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Holidaygroup>(entity =>
            {
                entity.ToTable("holidaygroup", "employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Jobgrade>(entity =>
            {
                entity.ToTable("jobgrade", "employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Maritalstatus>(entity =>
            {
                entity.ToTable("maritalstatus", "employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menu", "Users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionName)
                    .HasColumnName("action_name")
                    .HasMaxLength(200);

                entity.Property(e => e.Add).HasColumnName("add");

                entity.Property(e => e.ControllerName)
                    .HasColumnName("controller_name")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Edit).HasColumnName("edit");

                entity.Property(e => e.FontawesomeIcon)
                    .HasColumnName("fontawesomeIcon")
                    .HasMaxLength(200);

                entity.Property(e => e.MenuName)
                    .HasColumnName("menu_name")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Recstatus).HasColumnName("recstatus");
            });

            modelBuilder.Entity<Menurolemapping>(entity =>
            {
                entity.ToTable("menurolemapping", "Users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recstatus).HasColumnName("recstatus");

                entity.Property(e => e.RoleId).HasColumnName("role_id");
            });

            modelBuilder.Entity<Ottype>(entity =>
            {
                entity.ToTable("ottype", "employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Probation>(entity =>
            {
                entity.ToTable("probation", "employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.ToTable("registration", "employee");

                entity.Property(e => e.BiometricId)
                    .HasColumnName("biometric_id")
                    .HasMaxLength(200);

                entity.Property(e => e.ConfirmationDate)
                    .HasColumnName("confirmation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DayWorkedWeek)
                    .HasColumnName("day_worked_week")
                    .HasMaxLength(10);

                entity.Property(e => e.Department).HasColumnName("department");

                entity.Property(e => e.Designation).HasColumnName("designation");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("email_address")
                    .HasMaxLength(200);

                entity.Property(e => e.Empguidfilename)
                    .HasColumnName("empguidfilename")
                    .HasMaxLength(200);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("employee_code")
                    .HasMaxLength(200);

                entity.Property(e => e.Emppic)
                    .HasColumnName("emppic")
                    .HasMaxLength(200);

                entity.Property(e => e.FirstLevelApproval).HasColumnName("first_level_approval");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(200);

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.HolidayGroup).HasColumnName("holiday_group");

                entity.Property(e => e.Hourly)
                    .HasColumnName("hourly")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.HoursWorkedDay)
                    .HasColumnName("hours_worked_day")
                    .HasMaxLength(10);

                entity.Property(e => e.HoursWorkedYear)
                    .HasColumnName("hours_worked_year")
                    .HasMaxLength(10);

                entity.Property(e => e.JobGrade).HasColumnName("job_grade");

                entity.Property(e => e.JoinDate)
                    .HasColumnName("join_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaritalStatus).HasColumnName("marital_status");

                entity.Property(e => e.Mobileno)
                    .HasColumnName("mobileno")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ottype).HasColumnName("ottype");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(200);

                entity.Property(e => e.Probation).HasColumnName("probation");

                entity.Property(e => e.ReasonResignation)
                    .HasColumnName("reason_resignation")
                    .HasMaxLength(500);

                entity.Property(e => e.ResignDate)
                    .HasColumnName("resign_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RestDay).HasColumnName("rest_day");

                entity.Property(e => e.SecondLevelApproval).HasColumnName("second_level_approval");

                entity.Property(e => e.Section).HasColumnName("section");

                entity.Property(e => e.ShortName)
                    .HasColumnName("short_name")
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.ThirdLevelApproval).HasColumnName("third_level_approval");

                entity.Property(e => e.WorkingHoursPerShift).HasColumnName("working_hours_per_shift");

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.Department)
                    .HasConstraintName("FK__registrat__depar__5DCAEF64");

                entity.HasOne(d => d.DesignationNavigation)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.Designation)
                    .HasConstraintName("FK__registrat__desig__5FB337D6");

                entity.HasOne(d => d.FirstLevelApprovalNavigation)
                    .WithMany(p => p.InverseFirstLevelApprovalNavigation)
                    .HasForeignKey(d => d.FirstLevelApproval)
                    .HasConstraintName("FK__registrat__first__628FA481");

                entity.HasOne(d => d.GenderNavigation)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.Gender)
                    .HasConstraintName("FK__registrat__gende__5AEE82B9");

                entity.HasOne(d => d.HolidayGroupNavigation)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.HolidayGroup)
                    .HasConstraintName("FK__registrat__holid__60A75C0F");

                entity.HasOne(d => d.JobGradeNavigation)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.JobGrade)
                    .HasConstraintName("FK__registrat__job_g__619B8048");

                entity.HasOne(d => d.MaritalStatusNavigation)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.MaritalStatus)
                    .HasConstraintName("FK__registrat__marit__5BE2A6F2");

                entity.HasOne(d => d.ProbationNavigation)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.Probation)
                    .HasConstraintName("FK__registrat__proba__5CD6CB2B");

                entity.HasOne(d => d.SecondLevelApprovalNavigation)
                    .WithMany(p => p.InverseSecondLevelApprovalNavigation)
                    .HasForeignKey(d => d.SecondLevelApproval)
                    .HasConstraintName("FK__registrat__secon__6383C8BA");

                entity.HasOne(d => d.SectionNavigation)
                    .WithMany(p => p.Registration)
                    .HasForeignKey(d => d.Section)
                    .HasConstraintName("FK__registrat__secti__5EBF139D");

                entity.HasOne(d => d.ThirdLevelApprovalNavigation)
                    .WithMany(p => p.InverseThirdLevelApprovalNavigation)
                    .HasForeignKey(d => d.ThirdLevelApproval)
                    .HasConstraintName("FK__registrat__third__6477ECF3");
            });

            modelBuilder.Entity<Registration1>(entity =>
            {
                entity.ToTable("registration", "timesheet");

                entity.Property(e => e.ActualOtHr)
                    .HasColumnName("actual_ot_hr")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActualTimeIn)
                    .HasColumnName("actual_time_in")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActualTimeOut)
                    .HasColumnName("actual_time_out")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClockDate)
                    .HasColumnName("clock_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClockDay)
                    .HasColumnName("clock_day")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EarlyOut)
                    .HasColumnName("early_out")
                    .HasColumnType("datetime");

                entity.Property(e => e.Formattach)
                    .HasColumnName("formattach")
                    .HasMaxLength(200);

                entity.Property(e => e.Guidfileattach)
                    .HasColumnName("guidfileattach")
                    .HasMaxLength(200);

                entity.Property(e => e.Lateness)
                    .HasColumnName("lateness")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(200);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(50);

                entity.Property(e => e.RequestedEarlyout)
                    .HasColumnName("requested_earlyout")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestedLateness)
                    .HasColumnName("requested_lateness")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestedOtHr)
                    .HasColumnName("requested_ot_hr")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestedTimeIn)
                    .HasColumnName("requested_time_in")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestedTimeOut)
                    .HasColumnName("requested_time_out")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShiftTimeIn)
                    .HasColumnName("shift_time_in")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShiftTimeOut)
                    .HasColumnName("shift_time_out")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Registration1)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK__registrat__statu__68487DD7");
            });

            modelBuilder.Entity<RestDay>(entity =>
            {
                entity.ToTable("rest_day", "employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles", "Users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("section", "employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status", "employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Status1>(entity =>
            {
                entity.ToTable("status", "timesheet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<WorkingHoursShift>(entity =>
            {
                entity.ToTable("working_hours_shift", "employee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
