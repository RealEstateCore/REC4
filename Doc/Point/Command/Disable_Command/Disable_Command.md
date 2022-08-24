[Point](../../Point.md) > [Command](../Command.md) > [Disable_Command](.)
# Disable_Command

**Display name:** Disable Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Disable_Command;1

---


## Child interfaces
* [Disable_Differential_Enthalpy_Command](Disable_Differential_Enthalpy_Command.md)
* [Disable_Differential_Temperature_Command](Disable_Differential_Temperature_Command.md)
* [Disable_Fixed_Enthalpy_Command](Disable_Fixed_Enthalpy_Command.md)
* [Disable_Fixed_Temperature_Command](Disable_Fixed_Temperature_Command.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
