using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Model.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<asistencium> Asistencia { get; set; }

    public virtual DbSet<categorium> Categoria { get; set; }

    public virtual DbSet<cliente> Cliente { get; set; }

    public virtual DbSet<despacho> Despacho { get; set; }

    public virtual DbSet<documento> Documento { get; set; }

    public virtual DbSet<funcion> Funciones { get; set; }

    public virtual DbSet<grupo_funcion> GrupoFuncion { get; set; }

    public virtual DbSet<horario> Horario { get; set; }

    public virtual DbSet<item> Item { get; set; }

    public virtual DbSet<menu> Menu { get; set; }

    public virtual DbSet<menu_item> MenuItem { get; set; }

    public virtual DbSet<movimiento> Movimiento { get; set; }

    public virtual DbSet<orden> Ordene { get; set; }

    public virtual DbSet<orden_item> OrdenItem { get; set; }

    public virtual DbSet<planificador> Planificador { get; set; }

    public virtual DbSet<registro> Registro { get; set; }

    public virtual DbSet<rol> Rol { get; set; }

    public virtual DbSet<rol_funcion> RolFuncion { get; set; }

    public virtual DbSet<snack> Snack { get; set; }

    public virtual DbSet<usuario> Usuario { get; set; }

    public virtual DbSet<usuario_funcion> UsuarioFuncion { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.0.140;Database=food_service;User Id=sa;Password=sa2025;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<item>().HasNoDiscriminator();
        modelBuilder.Entity<asistencium>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__asistenc__3213E83F1367E606");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");
            entity.Property(e => e.tipo)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.usuarioNavigation).WithMany(p => p.asistencia)
                .HasForeignKey(d => d.usuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__asistenci__usuar__15502E78");
        });

        modelBuilder.Entity<categorium>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__categori__3213E83F7F60ED59");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<cliente>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__cliente__3213E83F0425A276");

            entity.ToTable("cliente");

            entity.HasIndex(e => e.codigo, "UQ__cliente__40F9A20607020F21").IsUnique();

            entity.Property(e => e.codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.documento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");
            entity.Property(e => e.fecha_ingreso).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.fotografia).HasColumnType("image");
            entity.Property(e => e.materno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.paterno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.tipo).HasDefaultValue(0);
        });

        modelBuilder.Entity<despacho>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__despacho__3213E83F25869641");

            entity.ToTable("despacho");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");

            entity.HasOne(d => d.ordenNavigation).WithMany(p => p.despachos)
                .HasForeignKey(d => d.orden)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__despacho__orden__276EDEB3");

            entity.HasOne(d => d.usuarioNavigation).WithMany(p => p.despachos)
                .HasForeignKey(d => d.usuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__despacho__usuari__286302EC");
        });

        modelBuilder.Entity<documento>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__document__3213E83F1920BF5C");

            entity.ToTable("documento");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<funcion>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__funcion__3213E83F30F848ED");

            entity.ToTable("funcion");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.grupoNavigation).WithMany(p => p.funcions)
                .HasForeignKey(d => d.grupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__funcion__grupo__32E0915F");
        });

        modelBuilder.Entity<grupo_funcion>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__grupo_fu__3213E83F2C3393D0");

            entity.ToTable("grupo_funcion");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<horario>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__horario__3213E83F3C69FB99");

            entity.ToTable("horario");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.planificadorNavigation).WithMany(p => p.horarios)
                .HasForeignKey(d => d.planificador)
                .HasConstraintName("FK__horario__planifi__3E52440B");
        });

        modelBuilder.Entity<item>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__item__3213E83F4222D4EF");

            entity.ToTable("item");

            entity.Property(e => e.descripcion).HasColumnType("text");
            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");
            entity.Property(e => e.imagen).HasColumnType("image");
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.categoriaNavigation).WithMany(p => p.items)
                .HasForeignKey(d => d.categoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__item__categoria__440B1D61");
        });

        modelBuilder.Entity<menu>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__menu__3213E83F47DBAE45");

            entity.ToTable("menu");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");

            entity.HasOne(d => d.horarioNavigation).WithMany(p => p.menus)
                .HasForeignKey(d => d.horario)
                .HasConstraintName("FK__menu__horario__49C3F6B7");
        });

        modelBuilder.Entity<menu_item>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("menu_item");

            entity.Property(e => e.descripcion).HasColumnType("text");
            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");

            entity.HasOne(d => d.itemNavigation).WithMany()
                .HasForeignKey(d => d.item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__menu_item__item__4D94879B");

            entity.HasOne(d => d.menuNavigation).WithMany()
                .HasForeignKey(d => d.menu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__menu_item__menu__4CA06362");
        });

        modelBuilder.Entity<movimiento>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__movimien__3213E83F5165187F");

            entity.ToTable("movimiento");

            entity.Property(e => e.detalle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");

            entity.HasOne(d => d.usuarioNavigation).WithMany(p => p.movimientos)
                .HasForeignKey(d => d.usuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__movimient__usuar__534D60F1");
        });

        modelBuilder.Entity<orden>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__orden__3213E83F1DE57479");

            entity.ToTable("orden");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");

            entity.HasOne(d => d.clienteNavigation).WithMany(p => p.ordens)
                .HasForeignKey(d => d.cliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__orden__cliente__20C1E124");

            entity.HasOne(d => d.documentoNavigation).WithMany(p => p.ordens)
                .HasForeignKey(d => d.documento)
                .HasConstraintName("FK__orden__documento__1FCDBCEB");

            entity.HasOne(d => d.usuarioNavigation).WithMany(p => p.ordens)
                .HasForeignKey(d => d.usuario)
                .HasConstraintName("FK__orden__usuario__21B6055D");
        });

        modelBuilder.Entity<orden_item>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("orden_item");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");

            entity.HasOne(d => d.itemNavigation).WithMany()
                .HasForeignKey(d => d.item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__orden_item__item__571DF1D5");

            entity.HasOne(d => d.ordenNavigation).WithMany()
                .HasForeignKey(d => d.orden)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__orden_ite__orden__5629CD9C");
        });

        modelBuilder.Entity<planificador>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__planific__3213E83F36B12243");

            entity.ToTable("planificador");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");

            entity.HasOne(d => d.usuarioNavigation).WithMany(p => p.planificadors)
                .HasForeignKey(d => d.usuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__planifica__usuar__38996AB5");
        });

        modelBuilder.Entity<registro>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__registro__3213E83F5AEE82B9");

            entity.ToTable("registro");

            entity.Property(e => e.cantidad).HasDefaultValue(1);
            entity.Property(e => e.cuenta)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("PERSONAL");
            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");
            entity.Property(e => e.tipo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("NONE");
            entity.Property(e => e.turno)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.clienteNavigation).WithMany(p => p.registros)
                .HasForeignKey(d => d.cliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__registro__client__5CD6CB2B");
        });

        modelBuilder.Entity<rol>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__rol__3213E83F6383C8BA");

            entity.ToTable("rol");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<rol_funcion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rol_funcion");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");

            entity.HasOne(d => d.funcionNavigation).WithMany()
                .HasForeignKey(d => d.funcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__rol_funci__funci__68487DD7");

            entity.HasOne(d => d.rolNavigation).WithMany()
                .HasForeignKey(d => d.rol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__rol_funcion__rol__6754599E");
        });

        modelBuilder.Entity<snack>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__snack__3213E83F7A672E12");

            entity.ToTable("snack");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");
            entity.Property(e => e.fecha).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.hora).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.tipo)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.clienteNavigation).WithMany(p => p.snacks)
                .HasForeignKey(d => d.cliente)
                .HasConstraintName("FK__snack__cliente__7D439ABD");

            entity.HasOne(d => d.itemNavigation).WithMany(p => p.snacks)
                .HasForeignKey(d => d.item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__snack__item__7E37BEF6");

            entity.HasOne(d => d.ordenNavigation).WithMany(p => p.snacks)
                .HasForeignKey(d => d.orden)
                .HasConstraintName("FK_snack_Orden");

            entity.HasOne(d => d.usuarioNavigation).WithMany(p => p.snacks)
                .HasForeignKey(d => d.usuario)
                .HasConstraintName("FK__snack__usuario__7C4F7684");
        });

        modelBuilder.Entity<usuario>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__usuario__3213E83F0BC6C43E");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.login, "UQ__usuario__7838F2720EA330E9").IsUnique();

            entity.Property(e => e.cargo)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.documento)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");
            entity.Property(e => e.fotografia).HasColumnType("image");
            entity.Property(e => e.login)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.materno)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.paterno)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<usuario_funcion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("usuario_funcion");

            entity.Property(e => e.estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("ACTIVO");

            entity.HasOne(d => d.funcionNavigation).WithMany()
                .HasForeignKey(d => d.funcion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usuario_f__funci__6C190EBB");

            entity.HasOne(d => d.usuarioNavigation).WithMany()
                .HasForeignKey(d => d.usuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__usuario_f__usuar__6B24EA82");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
