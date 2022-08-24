[Point](../../Point.md) > [Parameter](../Parameter.md) > [Tolerance_Parameter](Tolerance_Parameter.md) > [Humidity_Tolerance_Parameter](.)
# Humidity_Tolerance_Parameter

**Display name:** Humidity Tolerance Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Humidity_Tolerance_Parameter;1

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
