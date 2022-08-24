[Point](../../../Point.md) > [Command](../../Command.md) > [Load_Shed_Command](../Load_Shed_Command.md) > [Standby_Load_Shed_Command](Standby_Load_Shed_Command.md) > [Zone_Standby_Load_Shed_Command](.)
# Zone_Standby_Load_Shed_Command

**Display name:** Zone Standby Load Shed Command<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Zone_Standby_Load_Shed_Command;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
