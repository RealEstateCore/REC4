[Point](../../Point.md) > [Command](../Command.md) > [Override_Command](#)
# Override_Command

**Display name:** Override Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Override_Command;1

---


## Child interfaces
* [Curtailment_Override_Command](Curtailment_Override_Command.md)

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
