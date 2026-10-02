from pathlib import Path
from datetime import datetime


ROOT = Path(__file__).resolve().parent.parent
README = ROOT / "README.md"


def get_cs_files():
    return sorted(
        path.relative_to(ROOT)
        for path in ROOT.rglob("*.cs")
        if "bin" not in path.parts
        and "obj" not in path.parts
        and ".git" not in path.parts
    )


def get_csproj_files():
    return sorted(
        path.relative_to(ROOT)
        for path in ROOT.rglob("*.csproj")
        if "bin" not in path.parts
        and "obj" not in path.parts
    )


def generate_tree():
    lines = []

    for path in sorted(ROOT.iterdir()):
        if path.name in {".git", "bin", "obj"}:
            continue

        if path.name.startswith(".") and path.name != ".github":
            continue

        if path.is_dir():
            lines.append(f"{path.name}/")
        else:
            lines.append(path.name)

    return "\n".join(lines)


def generate_readme():
    cs_files = get_cs_files()
    csproj_files = get_csproj_files()

    content = f"""# Expense Tracker

A C#/.NET expense tracking application.

## Project Structure

```text
{generate_tree()}

