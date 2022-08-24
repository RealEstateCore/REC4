[Point](../../Point.md) > [Command](../Command.md) > [Frequency_Command](.)
# Frequency_Command

**Display name:** Frequency Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Frequency_Command;1

---


## Child interfaces
* [Max_Frequency_Command](Max_Frequency_Command.md)
* [Min_Frequency_Command](Min_Frequency_Command.md)

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
